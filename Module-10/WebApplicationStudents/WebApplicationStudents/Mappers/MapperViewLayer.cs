using AutoMapper;
using BusinessLogic.Models;
using WebApplicationStudents.Models;

namespace WebApplicationStudents.Mappers
{
    public class MapperViewLayer : Profile
    {
        public MapperViewLayer()
        {
            CreateMap<Homework, HomeworkBl>()
                .ReverseMap();
            CreateMap<Lector, LectorBl>()
              .ReverseMap();
            CreateMap<Lecture, LectureBl>()
              .ReverseMap();
            CreateMap<Student, StudentBl>()
               .ReverseMap();
            CreateMap<Attendance, AttendanceBl>()
                .ReverseMap();
            CreateMap<Mark, MarkBl>()
                .ReverseMap();
        }
    }
}
