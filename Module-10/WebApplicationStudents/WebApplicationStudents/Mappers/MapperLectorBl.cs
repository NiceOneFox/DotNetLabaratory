using AutoMapper;
using BusinessLogic.Models;
using WebApplicationStudents.Models;

namespace WebApplicationStudents.Mappers
{
    public class MapperLectorBl : Profile
    {
        public MapperLectorBl()
        {
            CreateMap<Lector, LectorBl>()
                .ReverseMap();
        }
    }
}
