using System;

namespace labs15_16.Models
{
    public class DepartmentDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Budget { get; set; }
        public DepartmentType DepartmentType { get; set; }

        public DepartmentDto(string name, string location, int budget, DepartmentType departmentType)
        {
            Name = name;
            Location = location;
            Budget = budget;
            DepartmentType = departmentType;
        }

        public bool IsValid()
        {
            return Name.Length <= 255 &&
                   Location.Length <= 200 &&
                   Budget >= 0 && Budget <= 100_000_000;
        }
    }
}