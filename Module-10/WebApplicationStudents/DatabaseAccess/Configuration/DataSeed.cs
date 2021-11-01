using DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Configuration
{
    public static class DataSeed
    {
        public static void InitializeWithValues(this ModelBuilder modelBuilder)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;

            modelBuilder.Entity<StudentDb>().HasData(
                new StudentDb[]
                {
                    new StudentDb { Id = 1, FirstName = "Oleg", LastName = "Leskov", Age = 24, Email = "oleg.leskov@mail.ru", Telephone = "+7(566)534-96-53", Score = 0 },
                    new StudentDb { Id = 2, FirstName = "Ivan", LastName = "Ivanovich", Age = 22, Email = "ivan.ivanovich@mail.ru", Telephone = "+7(866)735-46-33", Score = 0 },
                    new StudentDb { Id = 3, FirstName = "Egor", LastName = "Sizlov", Age = 21, Email = "egor.sizlov@mail.ru", Telephone = "+7(924)873-01-42", Score = 0 }
                });

            modelBuilder.Entity<LectorDb>().HasData(
                  new LectorDb[]
                  {
                    new LectorDb { Id = 1, FirstName = "Irina", LastName = "Vlasova", Email = "irina.vlasova@mail.ru", Position = "Lector"},
                    new LectorDb { Id = 2, FirstName = "Viktor", LastName = "Bolshov", Email = "viktor.bolshov@mail.ru", Position = "Main lector"},
                    new LectorDb { Id = 3, FirstName = "Vlad", LastName = "Gryaznov", Email = "vlad.gryaznov@mail.ru", Position = "Lector"}
                  });

            modelBuilder.Entity<HomeworkDb>().HasData(
                new HomeworkDb[]
                {
                    new HomeworkDb {Id = 1, Text = "Do homework and read book p. 45",
                        DeadLine = DateTime.ParseExact("11/23/2021 12:00", new string[] { "MM/dd/yyyy HH:mm" }, provider, DateTimeStyles.None), LectureId = 1 },
                    new HomeworkDb {Id = 2, Text = "Read article and book p. 65",
                        DeadLine = DateTime.ParseExact("11/28/2021 12:00", new string[] { "MM/dd/yyyy HH:mm" }, provider, DateTimeStyles.None), LectureId = 2},
                });

            modelBuilder.Entity<LectureDb>().HasData(
                new[]
                {
                    new {Id = 1, Date = DateTime.ParseExact("11/03/2021 16:00", new string[] { "MM/dd/yyyy HH:mm" }, provider, DateTimeStyles.None),
                        Name = "Docker", HomeworkId = 1, LectorId = 2},
                    new {Id = 2, Date = DateTime.ParseExact("11/14/2021 18:00", new string[] { "MM/dd/yyyy HH:mm" }, provider, DateTimeStyles.None),
                        Name = "SOLID", HomeworkId = 2, LectorId = 3}
                });

            modelBuilder.Entity<AttendanceDb>().HasData(
                 new []
                 {
                    new { StudentId = 1, LectureId = 1, IsAttend = true},
                    new { StudentId = 1, LectureId = 2, IsAttend = true},
                    new { StudentId = 2, LectureId = 1, IsAttend = true},
                    new { StudentId = 2, LectureId = 2, IsAttend = false},
                    new { StudentId = 3, LectureId = 1, IsAttend = true},
                    new { StudentId = 3, LectureId = 2, IsAttend = false},
                 });

            modelBuilder.Entity<MarkDb>().HasData(
                 new[]
                 {

                    new {Id = 1, Mark = 4, Text = "Little mistakes", LectureId = 1, StudentId = 2},
                    new {Id = 2, Mark = 5, Text = "Great work", LectureId = 2, StudentId = 2},
                    new {Id = 3, Mark = 3, Text = "Too simple", LectureId = 1, StudentId = 1},
                    new {Id = 4, Mark = 5, Text = "Great work", LectureId = 2, StudentId = 1},
                    new {Id = 5, Mark = 0, Text = "Didn't come to lecture", LectureId = 1, StudentId = 3},
                    new {Id = 6, Mark = 5, Text = "Great work", LectureId = 2, StudentId = 3}
                 });
        }
    }
}
