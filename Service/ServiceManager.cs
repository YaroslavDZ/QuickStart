using AutoMapper;
using Contracts;
using Microsoft.Extensions.Configuration;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IEmployeeService> _employeeService;

        public ServiceManager(IRepositoryManager repositoryManager,
              ILoggerManager logger, IMapper mapper, IConfiguration configuration)
        {
            _employeeService = new Lazy<IEmployeeService>(() => new EmployeeService(repositoryManager, logger, mapper));

        }

        public IEmployeeService EmployeeService => _employeeService.Value;
    }
}
