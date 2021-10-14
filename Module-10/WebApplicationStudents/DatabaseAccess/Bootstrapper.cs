using Microsoft.Extensions.DependencyInjection;
using DatabaseAccess.Repository;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, string connectionString)
        {
            return services
                .AddDbContext<CourseDbContext>(options => options.UseSqlServer(connectionString))
                .AddScoped<IStudentRepository, StudentRepository>();
        }
    }

}
