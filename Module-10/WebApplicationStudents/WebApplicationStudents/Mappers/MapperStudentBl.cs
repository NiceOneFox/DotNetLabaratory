using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Models;
using WebApplicationStudents.Models;

namespace WebApplicationStudents.Mappers
{
    public class MapperStudentBl : Profile
    {
        public MapperStudentBl()
        {
            CreateMap<Student, StudentBl>()
               .ReverseMap();
        }
    }
}
