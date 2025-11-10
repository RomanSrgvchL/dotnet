using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab14.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string FullName { get; set; } = null!;
        public string Position { get; set; } = null!;
        public byte[]? Photo { get; set; }

        [NotMapped]
        public IFormFile? PhotoFile { get; set; }

        public virtual Department Department { get; set; } = null!;
    }
}
