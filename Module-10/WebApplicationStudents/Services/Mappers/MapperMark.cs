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
    public class MapperMark : Profile
    {
        public MapperMark()
        {
            CreateMap<MarkBl, MarkDb>()
                .ReverseMap();
        }
    }
}
