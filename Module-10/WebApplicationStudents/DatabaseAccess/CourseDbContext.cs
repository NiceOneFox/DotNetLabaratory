using DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess
{
    public class CourseDbContext : DbContext
    {
        public DbSet<StudentDb> Students { get; set; }
        public DbSet<LectureDb> Lectures { get; set; }
        public DbSet<LectorDb> Lectors { get; set; }
        public DbSet<HomeworkDb> Homeworks { get; set; }
        public DbSet<MarkDb> Marks { get; set; }


        public CourseDbContext(DbContextOptions<CourseDbContext> options)
            :base(options)
        {

        }
    }
}