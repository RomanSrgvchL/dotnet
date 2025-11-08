using System;
using System.Linq;

namespace lab11.model
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public byte[] Photo { get; set; }

        public string DepartmentName { get; set; }

        public Employee(int departmentId, string fullName, string position, byte[] photo = null)
        {
            DepartmentId = departmentId;
            FullName = fullName;
            Position = position;
            Photo = photo;
            DepartmentName = string.Empty;
        }

        public Employee(int id, int departmentId, string fullName, string position, byte[] photo = null) : 
            this(departmentId, fullName, position, photo)
        {
            Id = id;
        }

        public bool IsValid()
        {
            return FullName.Length <= 100 &&
                   Position.Length <= 50 &&
                   DepartmentId > 0;
        }
    }
}