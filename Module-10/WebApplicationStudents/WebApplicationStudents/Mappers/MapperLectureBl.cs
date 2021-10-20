using AutoMapper;
using BusinessLogic.Models;
using WebApplicationStudents.Models;

namespace WebApplicationStudents.Mappers
{
    public class MapperLectureBl : Profile
    {
        public MapperLectureBl()
        {
            CreateMap<Lecture, LectureBl>()
                .ReverseMap();
        }
    }
}
