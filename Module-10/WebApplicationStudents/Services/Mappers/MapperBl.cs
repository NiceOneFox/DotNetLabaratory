using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Models;
using DatabaseAccess.Models;

namespace BusinessLogic.Mappers
{
    public class MapperBl : Profile
    {
        public MapperBl()
        {
            CreateMap<HomeworkBl, HomeworkDb>()
                .ReverseMap();
            CreateMap<LectorBl, LectorDb>()
               .ReverseMap();
            CreateMap<LectureBl, LectureDb>()
              .ReverseMap();
            CreateMap<StudentBl, StudentDb>().
                ReverseMap();
            CreateMap<MarkBl, MarkDb>()
               .ReverseMap();
            CreateMap<AttendanceBl, AttendanceDb>()
                .ReverseMap();
        }
    }
}
