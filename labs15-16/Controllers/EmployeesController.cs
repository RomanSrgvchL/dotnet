using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labs15_16.Data;
using labs15_16.Dtos;
using labs15_16.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace labs15_16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly Context _context;

        public EmployeesController(Context context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetEmployees()
        {
            var employees = await _context.Employees
                .Include(e => e.Department)
                .OrderBy(e => e.Id)
                .Select(e => new
                {
                    e.Id,
                    e.FullName,
                    e.Position,
                    e.DepartmentId,
                    Photo = e.Photo == null ? null : Convert.ToBase64String(e.Photo),
                    Department = e.Department == null ? null : new { e.Department.Id, e.Department.Name }
                })
                .ToListAsync();

            return Ok(employees);
        }

        // GET: api/Employees/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<object>> GetEmployee(int id)
        {
            if (id <= 0)
            {
                return BadRequest("ID должен быть положительным числом");
            }

            var employee = await _context.Employees
                .Include(e => e.Department)
                .Where(e => e.Id == id)
                .Select(e => new
                {
                    e.Id,
                    e.FullName,
                    e.Position,
                    e.DepartmentId,
                    Photo = e.Photo == null ? null : Convert.ToBase64String(e.Photo),
                    Department = e.Department == null ? null : new { e.Department.Id, e.Department.Name }
                })
                .FirstOrDefaultAsync();

            if (employee == null) return NotFound();
            return Ok(employee);
        }

        // POST: api/Employees
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee([FromForm] EmployeeFormData formData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            byte[] photoBytes = null;
            if (formData.Photo != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await formData.Photo.CopyToAsync(memoryStream);
                    photoBytes = memoryStream.ToArray();
                }
            }

            var employeeDto = new EmployeeDto(
                formData.DepartmentId,
                formData.FullName,
                formData.Position,
                photoBytes
            );

            if (!employeeDto.IsValid())
            {
                return BadRequest("Некорректные данные сотрудника");
            }

            Employee employee = new Employee(employeeDto.DepartmentId, employeeDto.FullName,
                employeeDto.Position, employeeDto.Photo);

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
        }

        // PUT: api/Employees/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, [FromForm] EmployeeFormData formData)
        {
            if (id <= 0)
            {
                return BadRequest("ID должен быть положительным числом");
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound($"Сотрудник с ID {id} не найден");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Обновляем фото только если новое было загружено
            if (formData.Photo != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await formData.Photo.CopyToAsync(memoryStream);
                    employee.Photo = memoryStream.ToArray();
                }
            }

            employee.DepartmentId = formData.DepartmentId;
            employee.FullName = formData.FullName;
            employee.Position = formData.Position;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                    return NotFound($"Сотрудник с ID {id} был удален другим пользователем");
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/Employees/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            if (id <= 0)
            {
                return BadRequest("ID должен быть положительным числом");
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) return NotFound();
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool EmployeeExists(int id) =>
            _context.Employees.Any(e => e.Id == id);
    }

    // Модель для получения данных из формы
    public class EmployeeFormData
    {
        public int DepartmentId { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public IFormFile Photo { get; set; }
    }
}