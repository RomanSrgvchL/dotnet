using labs15_16.Models;

namespace labs15_16.Dtos
{
    public class EmployeeDto
    {
        public int DepartmentId { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public byte[]? Photo { get; set; }

        public EmployeeDto(int departmentId, string fullName, string position, byte[]? photo = null)
        {
            DepartmentId = departmentId;
            FullName = fullName;
            Position = position;
            Photo = photo;
        }

        public bool IsValid()
        {
            return FullName.Length <= 100 &&
                   Position.Length <= 50 &&
                   DepartmentId > 0;
        }
    }
}
