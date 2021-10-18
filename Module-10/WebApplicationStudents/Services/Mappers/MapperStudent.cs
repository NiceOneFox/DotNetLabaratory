using AutoMapper;
using BusinessLogic.Models;
using DatabaseAccess.Models;

namespace BusinessLogic.Mappers
{
    public class MapperStudent : Profile
    {
        public MapperStudent()
        {
            CreateMap<Student, StudentDb>().
                ReverseMap();
        }
    }
}
