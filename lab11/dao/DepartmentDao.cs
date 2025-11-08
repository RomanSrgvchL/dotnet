using lab11.model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace lab11.dao
{
    public class DepartmentDao
    {
        private readonly NpgsqlConnection connection;

        public DepartmentDao()
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

        public List<Department> GetDepartments()
        {
            var departments = new List<Department>();

            using (var command = new NpgsqlCommand("SELECT * FROM departments ORDER BY id", connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string typeString = reader.GetString(reader.GetOrdinal("department_type"));
                    DepartmentType departmentType = (DepartmentType)Enum.Parse(typeof(DepartmentType), typeString, true);

                    var department = new Department
                    (
                        id: reader.GetInt32(reader.GetOrdinal("id")),
                        name: reader.GetString(reader.GetOrdinal("name")),
                        location: reader.GetString(reader.GetOrdinal("location")),
                        budget: reader.GetInt32(reader.GetOrdinal("budget")),
                        departmentType: departmentType
                    );
                    departments.Add(department);
                }
            }

            return departments;
        }

        public void Update(Department department)
        {
            string query = @"UPDATE departments 
                           SET name = @name, location = @location, budget = @budget, department_type = @department_type 
                           WHERE id = @id";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", department.Name);
                command.Parameters.AddWithValue("@location", department.Location);
                command.Parameters.AddWithValue("@budget", department.Budget);
                command.Parameters.AddWithValue("@department_type", department.DepartmentType.ToString());
                command.Parameters.AddWithValue("@id", department.Id);

                command.ExecuteNonQuery();
            }
        }

        public int Add(Department department)
        {
            string query = @"INSERT INTO departments (name, location, budget, department_type) 
                           VALUES (@name, @location, @budget, @department_type) 
                           RETURNING id";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", department.Name);
                command.Parameters.AddWithValue("@location", department.Location);
                command.Parameters.AddWithValue("@budget", department.Budget);
                command.Parameters.AddWithValue("@department_type", department.DepartmentType.ToString());

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM departments WHERE id = @id";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
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

        ~DepartmentDao()
        {
            CloseConnection();
            if (connection != null)
            {
                connection.Dispose();
            }
        }
    }
}