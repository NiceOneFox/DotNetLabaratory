using AutoMapper;
using BusinessLogic.Models;
using DatabaseAccess.Models;

namespace BusinessLogic.Mappers
{
    internal class MapperStudent : Profile
    {
        public MapperStudent()
        {
            CreateMap<Student, StudentDb>().
                ReverseMap();
            
        }
    }
}
