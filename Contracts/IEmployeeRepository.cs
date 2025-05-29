using Entities.Models;

namespace Contracts
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync(bool trackChanges);
        Task<Employee> GetEmployeeAsync(Guid employeeId, bool trackChanges);
        void CreateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
