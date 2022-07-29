using api2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        EmployeeDbContext _context;
        public EmployeesController(EmployeeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var empList = await _context.emps.ToListAsync();
            return Ok(empList);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var stdObj = await _context.emps.FindAsync(id);

            if (stdObj != null)
                return Ok(stdObj);
            else
                return NotFound("Requested Product Id does not exists.");
        }


        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee obj)
        {
            await _context.emps.AddAsync(obj);
            await _context.SaveChangesAsync();
            return Ok("New Employee details are saved in database.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent(Employee obj)
        {
            _context.emps.Update(obj);
            await _context.SaveChangesAsync();
            return Ok("Student details are updated in database.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var stdObj = await _context.emps.FindAsync(id);
            _context.emps.Remove(stdObj);
            await _context.SaveChangesAsync();
            return Ok("Student details are deleted from database.");
        }

    }
}
