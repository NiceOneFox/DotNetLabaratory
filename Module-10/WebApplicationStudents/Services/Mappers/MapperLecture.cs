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
    public class MapperLecture : Profile
    {
        public MapperLecture()
        {
            CreateMap<LectureBl, LectureDb>()
                .ReverseMap();
        }
    }
}
