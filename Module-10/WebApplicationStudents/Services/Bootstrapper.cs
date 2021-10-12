using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using BusinessLogic.Mappers;
using DatabaseAccess;

namespace BusinessLogic
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services, string connectionString)
        {
            return services
                .AddScoped<IStudentService, StudentService>()
                .AddAutoMapper(typeof(MapperStudent))
                .AddDataAccess(connectionString);
        }
    }
}
