using Microsoft.Extensions.DependencyInjection;
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
