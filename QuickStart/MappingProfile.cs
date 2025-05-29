using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects.Employee;

namespace QuickStart
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Employee, EmployeeDto>();
            
            CreateMap<EmployeeForCreationDto, Employee>();
            
            CreateMap<EmployeeForUpdateDto, Employee>();
        }
    }
}
