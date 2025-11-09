using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labs15_16.Data;
using labs15_16.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace labs15_16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly Context _context;

        public DepartmentsController(Context context)
        {
            _context = context;
        }

        // GET api/Departments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetDepartments()
        {
            var departments = await _context.Departments
                .Select(d => new
                {
                    d.Id,
                    d.Name,
                    d.Location,
                    d.Budget,
                    DepartmentTypeString = d.DepartmentType,
                    EmployeesCount = d.Employees.Count
                })
                .ToListAsync();
            return Ok(departments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<object>> GetDepartment(int id)
        {
            if (id <= 0)
            {
                return BadRequest("ID должен быть положительным числом");
            }

            var department = await _context.Departments
            .Include(d => d.Employees)
            .Where(d => d.Id == id)
            .Select(d => new
            {
                d.Id,
                d.Name,
                d.Location,
                d.Budget,
                DepartmentTypeString = d.DepartmentType,
                Employees = d.Employees.Select(e => new
                {
                    e.Id,
                    e.FullName,
                    e.Position,
                    Photo = e.Photo == null ? null : Convert.ToBase64String(e.Photo)
                }).ToList()
            })
            .FirstOrDefaultAsync();

            if (department == null)
                return NotFound();

            return Ok(department);
        }

        // POST api/Departments
        [HttpPost]
        public async Task<ActionResult<Department>> PostDepartment(DepartmentDto departmentDto)
        {
            if (!departmentDto.IsValid())
            {
                return BadRequest("Некорректные данные отдела");
            }

            Department department = new Department(departmentDto.Name, departmentDto.Location,
                departmentDto.Budget, departmentDto.DepartmentType);

            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetDepartment), new { id = department.Id }, department);
        }

        // PUT api/Departments/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment(int id, DepartmentDto departmentDto)
        {
            if (id <= 0)
            {
                return BadRequest("ID должен быть положительным числом");
            }

            var department = await _context.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound($"Отдел с ID {id} не найден");
            }

            if (!departmentDto.IsValid())
            {
                return BadRequest("Некорректные данные отдела");
            }

            department.Name = departmentDto.Name;
            department.Location = departmentDto.Location;
            department.Budget = departmentDto.Budget;
            department.DepartmentType = departmentDto.DepartmentType;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
                    return NotFound($"Отдел с ID {id} был удален другим пользователем");
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE api/Departments/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartmentForce(int id)
        {
            if (id <= 0)
            {
                return BadRequest("ID должен быть положительным числом");
            }

            var department = await _context.Departments
                .Include(d => d.Employees)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (department == null) return NotFound();

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool DepartmentExists(int id) =>
            _context.Departments.Any(e => e.Id == id);
    }
}