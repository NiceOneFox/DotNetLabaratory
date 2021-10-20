using AutoMapper;
using BusinessLogic.Models;
using WebApplicationStudents.Models;

namespace WebApplicationStudents.Mappers
{
    public class MapperHomeworkBl : Profile
    {
        public MapperHomeworkBl()
        {
            CreateMap<Homework, HomeworkBl>()
                .ReverseMap();
        }
    }
}
