using AutoMapper;
using Demo.DAL.Entities;
using Demo.PL.ViewModels;

namespace Demo.PL.Mappers
{
    public class DepartmentProfile:Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department,DepartmentViewModel>().ReverseMap();
        }
    }
}
