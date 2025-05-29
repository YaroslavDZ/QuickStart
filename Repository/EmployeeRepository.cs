using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    internal sealed class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateEmployee(Employee employee)
        {
            Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }

        public async Task<Employee> GetEmployeeAsync(Guid employeeId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(employeeId), trackChanges)
                .SingleOrDefaultAsync();

        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.FirstName)
                .ToListAsync();
        }
    }
}
