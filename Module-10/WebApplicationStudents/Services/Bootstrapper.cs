using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using BusinessLogic.Mappers;
using DatabaseAccess;
using BusinessLogic.ServiceInterfaces;
using BusinessLogic.Services;
using BusinessLogic.EmailSender;
using Twilio.Clients;
using BusinessLogic.SMSSender;

namespace BusinessLogic
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services, string connectionString)
        {
            return services
                .AddScoped<IStudentService, StudentService>()
                .AddScoped<ILectorService, LectorService>()
                .AddScoped<ILectureService, LectureService>()
                .AddScoped<IHomeworkService, HomeworkService>()
                .AddScoped<IAttendanceService, AttendanceService>()
                .AddScoped<IMarkService, MarkService>()
                .AddScoped<IEmailService, EmailService>()
                .AddAutoMapper(typeof(MapperBl))
                .AddDataAccess(connectionString);  
        }
    }
}
