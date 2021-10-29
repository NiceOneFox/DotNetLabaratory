using DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;

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
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDb>()
                .HasMany(s => s.Lectures)
                .WithMany(l => l.Students)
                .UsingEntity<AttendanceDb>(
                    j => j.HasOne(a => a.Lecture).WithMany(l => l.Attendances),
                    j => j.HasOne(a => a.Student).WithMany(s => s.Attendances)
                    );

            //modelBuilder.Entity<LectorDb>()
            //    .HasMany(l => l.Lectures)
            //    .WithOne(l => l.Lector);

            //modelBuilder.Entity<MarkDb>()
            //    .HasOne(m => m.Lecture);

            //modelBuilder.Entity<HomeworkDb>()
            //    .HasOne(h => h.Lecture);
            //modelBuilder.Entity<StudentLecture>().HasKey(sc => new { sc.StudentId, sc.LectureId });

            //CultureInfo provider = CultureInfo.InvariantCulture;

            //StudentDb[] students = new StudentDb[]
            //{
            //    new StudentDb { Id = 1, FirstName = "Oleg", LastName = "Leskov", Age = 24, Email = "oleg.leskov@mail.ru", Score = 0 },
            //        new StudentDb { Id = 2, FirstName = "Ivan", LastName = "Ivanovich", Age = 22, Email = "ivan.ivanovich@mail.ru", Score = 0 },
            //        new StudentDb { Id = 3, FirstName = "Egor", LastName = "Sizlov", Age = 21, Email = "egor.sizlov@mail.ru", Score = 0 }
            //};

            //modelBuilder.Entity<StudentDb>().HasData(
            //    new StudentDb[]
            //    {
            //        new StudentDb { Id = 1, FirstName = "Oleg", LastName = "Leskov", Age = 24, Email = "oleg.leskov@mail.ru", Score = 0 },
            //        new StudentDb { Id = 2, FirstName = "Ivan", LastName = "Ivanovich", Age = 22, Email = "ivan.ivanovich@mail.ru", Score = 0 },
            //        new StudentDb { Id = 3, FirstName = "Egor", LastName = "Sizlov", Age = 21, Email = "egor.sizlov@mail.ru", Score = 0 }
            //    });


            //modelBuilder.Entity<LectureDb>().HasData(
            //    new[]
            //    {
            //        new {Id = 1, Date = DateTime.ParseExact("11/03/2021", new string[] { "MM.dd.yyyy", "MM-dd-yyyy", "MM/dd/yyyy" }, provider, DateTimeStyles.None),
            //            Name = "Docker", HomeworkId = 1, LectorId = 2},
            //        new {Id = 2, Date = DateTime.ParseExact("11/14/2021", new string[] { "MM.dd.yyyy", "MM-dd-yyyy", "MM/dd/yyyy" }, provider, DateTimeStyles.None),
            //            Name = "SOLID", HomeworkId = 2, LectorId = 3}
            //    });


            //modelBuilder.Entity<LectorDb>().HasData(
            //    new LectorDb[]
            //    {
            //        new LectorDb { Id = 1, FirstName = "Irina", LastName = "Vlasova", Email = "irina.vlasova@mail.ru", Position = "Lector"},
            //        new LectorDb { Id = 2, FirstName = "Viktor", LastName = "Bolshov", Email = "viktor.bolshov@mail.ru", Position = "Main lector"},
            //        new LectorDb { Id = 3, FirstName = "Vlad", LastName = "Gryaznov", Email = "vlad.gryaznov@mail.ru", Position = "Lector"}
            //    });

            //modelBuilder.Entity<HomeworkDb>().HasData(
            //                new[]
            //                {
            //        new {Id = 1, Text = "Do homework and read book p. 45", DeadLine = DateTime.ParseExact("11/23/2021", new string[] { "MM.dd.yyyy", "MM-dd-yyyy", "MM/dd/yyyy" }, provider, DateTimeStyles.None), LectureId = 1},
            //        new {Id = 2, Text = "Read article and book p. 65", DeadLine = DateTime.ParseExact("11/28/2021", new string[] { "MM.dd.yyyy", "MM-dd-yyyy", "MM/dd/yyyy" }, provider, DateTimeStyles.None), LectureId = 2},
            //                });


            //modelBuilder.Entity<MarkDb>().HasData(
            //     new[]
            //     {

            //        new {Id = 1, Mark = 4, Text = "Little mistakes", LectureId = 1, StudentId = 2},
            //        new {Id = 2, Mark = 5, Text = "Great work", LectureId = 2, StudentId = 2},
            //        new {Id = 3, Mark = 3, Text = "Too simple", LectureId = 1, StudentId = 1},
            //        new {Id = 4, Mark = 5, Text = "Great work", LectureId = 2, StudentId = 1},
            //        new {Id = 5, Mark = 0, Text = "Didn't come to lecture", LectureId = 1, StudentId = 3},
            //        new {Id = 6, Mark = 5, Text = "Great work", LectureId = 2, StudentId = 3}
            //     });

        }
    }
}