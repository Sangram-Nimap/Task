using Crud30_06_25.Data;
using Crud30_06_25.Dtos;
using Crud30_06_25.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crud30_06_25.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbConnection _context;

        public EmployeeController(AppDbConnection context)
        {
            this._context = context;
        }


        [HttpGet]
        public IActionResult GetEmployee() {
            var employee = _context.Employees.ToList();
            return Ok(employee);
        }
        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var employee = _context.Employees.Find(Id);
            if (employee is null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
     public IActionResult AddEmployee(EmployeeDto employeeDto)
        {
            var employee = new Employee()
            {
                Name =employeeDto.Name,
                Salary = employeeDto.Salary,
                address =employeeDto.address
            };
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Ok(employee);

        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmploye(int id , EmployeeDto employeeDto)
        {
            var employee = _context.Employees.Find(id);
            if (employee is null)
            {
                return NotFound();
            }
            employee.Name = employeeDto.Name;
            employee.Salary = employeeDto.Salary;
            employee.address = employeeDto.address;
            _context.SaveChanges();
            return Ok(employee);


        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee is null)
            {
                return NotFound();
            }
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return Ok(employee);

        }


    }
}
