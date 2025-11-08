using System;

namespace lab11.model
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Budget { get; set; }
        public DepartmentType DepartmentType { get; set; }

        public Department(string name, string location, int budget, DepartmentType departmentType)
        {
            Name = name;
            Location = location;
            Budget = budget;
            DepartmentType = departmentType;
        }

        public Department(int id, string name, string location, int budget, DepartmentType departmentType)
            : this(name, location, budget, departmentType)
        {
            Id = id;
        }

        public bool IsValid()
        {
            return Name.Length <= 255 &&
                   Location.Length <= 200 &&
                   Budget >= 0 && Budget <= 100_000_000;
        }
    }
}