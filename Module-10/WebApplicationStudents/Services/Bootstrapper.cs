using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using BusinessLogic.Mappers;
using DatabaseAccess;
using BusinessLogic.ServiceInterfaces;
using BusinessLogic.Services;

namespace BusinessLogic
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services, string connectionString)
        {
            return services
                .AddScoped<IStudentService, StudentService>()
                .AddAutoMapper(typeof(MapperStudent))
                .AddScoped<ILectorService, LectorService>()
                .AddAutoMapper(typeof(MapperLector))
                .AddScoped<ILectureService, LectureService>()
                .AddAutoMapper(typeof(MapperLecture))      
                .AddScoped<IHomeworkService, HomeworkService>()
                .AddAutoMapper(typeof(MapperHomework))
                //.AddAutoMapper(typeof(MapperMark))
                .AddDataAccess(connectionString);
        }
    }
}
