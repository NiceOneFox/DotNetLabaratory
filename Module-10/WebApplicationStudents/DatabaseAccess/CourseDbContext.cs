using DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using DatabaseAccess.Configuration;

namespace DatabaseAccess
{
    public class CourseDbContext : DbContext
    {
        public DbSet<StudentDb> Students { get; set; }
        public DbSet<LectureDb> Lectures { get; set; }
        public DbSet<LectorDb> Lectors { get; set; }
        public DbSet<HomeworkDb> Homeworks { get; set; }
        public DbSet<MarkDb> Marks { get; set; }
        public DbSet<AttendanceDb> Attendances { get; set; }
        public DbSet<SeriesDb> Series { get; set; }


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
                    j => j.HasOne(a => a.Lecture).WithMany(l => l.Attendances).HasForeignKey(l => l.LectureId),
                    j => j.HasOne(a => a.Student).WithMany(s => s.Attendances).HasForeignKey(l => l.StudentId)
                    );

            modelBuilder.Entity<LectureDb>()
                .HasOne(l => l.Homework)
                .WithOne(l => l.Lecture)
                .HasForeignKey<HomeworkDb>(l => l.LectureId);

            modelBuilder.Entity<LectorDb>()
                .HasOne(l => l.Series)
                .WithOne(s => s.Lector)
                .HasForeignKey<SeriesDb>(s => s.LectorId);
                

            modelBuilder.InitializeWithValues();

        }
    }
}