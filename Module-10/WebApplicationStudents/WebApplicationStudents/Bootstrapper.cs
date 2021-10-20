using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationStudents.Mappers;

namespace WebApplicationStudents
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            return services
                .AddAutoMapper(typeof(MapperStudentBl))
                .AddAutoMapper(typeof(MapperLectureBl))
                .AddAutoMapper(typeof(MapperLectorBl))
                .AddAutoMapper(typeof(MapperHomeworkBl));
        }
    }
}
