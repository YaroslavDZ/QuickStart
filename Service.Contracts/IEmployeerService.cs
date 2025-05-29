using Shared.DataTransferObjects.Employee;

namespace Service.Contracts
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync(bool trackChanges);
        Task<EmployeeDto> GetEmployeeAsync(Guid employeeId, bool trackChanges);
        Task<EmployeeDto> CreateEmployeeAsync(EmployeeForCreationDto employee);
        Task DeleteEmployeeAsync(Guid employeeId, bool trackChanges);
        Task UpdateEmployeeAsync(Guid employeeId, EmployeeForUpdateDto employeeForUpdate, bool trackChanges);
    }
}
