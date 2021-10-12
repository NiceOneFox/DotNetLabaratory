using DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess
{
    public class CourseDbContext : DbContext
    {
        public DbSet<StudentDb> Students { get; set; }

        public CourseDbContext(DbContextOptions<CourseDbContext> options)
            :base(options)
        {

        }
    }
}