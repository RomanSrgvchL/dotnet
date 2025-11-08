using lab11.model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace lab11.dao
{
    public class EmployeeDao
    {
        private readonly NpgsqlConnection connection;

        public EmployeeDao()
        {
            try
            {
                using (StreamReader reader = new StreamReader("resources/database.txt"))
                {
                    connection = new NpgsqlConnection(reader.ReadLine());
                    OpenConnection();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Ошибка при чтении файла: " + e.Message);
            }
        }

        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();

            string query = @"SELECT e.id, e.department_id, e.full_name, e.position, e.photo, d.name as department_name
                           FROM employees e 
                           LEFT JOIN departments d ON e.department_id = d.id 
                           ORDER BY e.id";

            using (var command = new NpgsqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var employee = new Employee(
                        id: reader.GetInt32(reader.GetOrdinal("id")),
                        departmentId: reader.GetInt32(reader.GetOrdinal("department_id")),
                        fullName: reader.GetString(reader.GetOrdinal("full_name")),
                        position: reader.GetString(reader.GetOrdinal("position")),
                        photo: reader.IsDBNull(reader.GetOrdinal("photo")) ? null : (byte[])reader["photo"]
                    );
                    employee.DepartmentName = reader.GetString(reader.GetOrdinal("department_name"));
                    employees.Add(employee);
                }
            }

            return employees;
        }

        public void Update(Employee employee)
        {
            string query = @"UPDATE employees 
                           SET department_id = @department_id, full_name = @full_name, 
                               position = @position, photo = @photo 
                           WHERE id = @id";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@department_id", employee.DepartmentId);
                command.Parameters.AddWithValue("@full_name", employee.FullName);
                command.Parameters.AddWithValue("@position", employee.Position);
                command.Parameters.AddWithValue("@photo", employee.Photo ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@id", employee.Id);

                command.ExecuteNonQuery();
            }
        }

        public int Add(Employee employee)
        {
            string query = @"INSERT INTO employees (department_id, full_name, position, photo) 
                           VALUES (@department_id, @full_name, @position, @photo) 
                           RETURNING id";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@department_id", employee.DepartmentId);
                command.Parameters.AddWithValue("@full_name", employee.FullName);
                command.Parameters.AddWithValue("@position", employee.Position);
                command.Parameters.AddWithValue("@photo", employee.Photo ?? (object)DBNull.Value);

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM employees WHERE id = @id";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public Employee GetEmployeeById(int id)
        {
            string query = @"SELECT e.id, e.department_id, e.full_name, e.position, e.photo, d.name as department_name
                           FROM employees e 
                           LEFT JOIN departments d ON e.department_id = d.id 
                           WHERE e.id = @id";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var employee = new Employee(
                            id: reader.GetInt32(reader.GetOrdinal("id")),
                            departmentId: reader.GetInt32(reader.GetOrdinal("department_id")),
                            fullName: reader.GetString(reader.GetOrdinal("full_name")),
                            position: reader.GetString(reader.GetOrdinal("position")),
                            photo: reader.IsDBNull(reader.GetOrdinal("photo")) ? null : (byte[])reader["photo"]
                        );
                        employee.DepartmentName = reader.GetString(reader.GetOrdinal("department_name"));
                        return employee;
                    }
                }
            }

            return null;
        }

        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        ~EmployeeDao()
        {
            CloseConnection();
            if (connection != null)
            {
                connection.Dispose();
            }
        }
    }
}