using Microsoft.AspNetCore.Mvc;
using QuickStart.Presentation.ActionFilters;
using Service.Contracts;
using Shared.DataTransferObjects.Employee;

namespace QuickStart.Presentation.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IServiceManager _service;

        public EmployeeController(IServiceManager service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _service.EmployeeService.GetAllEmployeesAsync(trackChanges: false);

            return Ok(employees);
        }

        [HttpGet("{id:guid}", Name = "EmployeeById")]
        public async Task<IActionResult> GetEmployee(Guid id)
        {
            var employee = await _service.EmployeeService.GetEmployeeAsync(id, trackChanges: false);
            return Ok(employee);
        }


        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeeForCreationDto employee)
        {
            var createdEmployee = await _service.EmployeeService.CreateEmployeeAsync(employee);

            return CreatedAtRoute("EmployeeById", new { id = createdEmployee.Id }, createdEmployee);
        }


        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteEmployee(Guid id)
        {
            await _service.EmployeeService.DeleteEmployeeAsync(id, trackChanges: false);

            return NoContent();
        }

        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateEmployee(Guid id, [FromBody] EmployeeForUpdateDto employee)
        {
            await _service.EmployeeService.UpdateEmployeeAsync(id, employee, trackChanges: true);

            return NoContent();
        }
    }
}
