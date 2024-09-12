using AutoMapper;
using Company.Data.Models;
using Company.Servise.Interfaces.Employee;

namespace Company.Servise.Mapping
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile() 
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}
