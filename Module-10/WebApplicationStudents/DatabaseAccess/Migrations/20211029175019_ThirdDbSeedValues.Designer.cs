﻿// <auto-generated />
using System;
using DatabaseAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseAccess.Migrations
{
    [DbContext(typeof(CourseDbContext))]
    [Migration("20211029175019_ThirdDbSeedValues")]
    partial class ThirdDbSeedValues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatabaseAccess.Models.AttendanceDb", b =>
                {
                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<bool>("isAttend")
                        .HasColumnType("bit");

                    b.HasKey("LectureId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendances");

                    b.HasData(
                        new
                        {
                            LectureId = 1,
                            StudentId = 1,
                            isAttend = true
                        },
                        new
                        {
                            LectureId = 2,
                            StudentId = 1,
                            isAttend = true
                        },
                        new
                        {
                            LectureId = 1,
                            StudentId = 2,
                            isAttend = true
                        },
                        new
                        {
                            LectureId = 2,
                            StudentId = 2,
                            isAttend = false
                        },
                        new
                        {
                            LectureId = 1,
                            StudentId = 3,
                            isAttend = true
                        },
                        new
                        {
                            LectureId = 2,
                            StudentId = 3,
                            isAttend = false
                        });
                });

            modelBuilder.Entity("DatabaseAccess.Models.HomeworkDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LectureId")
                        .IsUnique();

                    b.ToTable("Homeworks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeadLine = new DateTime(2021, 11, 23, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            LectureId = 1,
                            Text = "Do homework and read book p. 45"
                        },
                        new
                        {
                            Id = 2,
                            DeadLine = new DateTime(2021, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            LectureId = 2,
                            Text = "Read article and book p. 65"
                        });
                });

            modelBuilder.Entity("DatabaseAccess.Models.LectorDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lectors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "irina.vlasova@mail.ru",
                            FirstName = "Irina",
                            LastName = "Vlasova",
                            Position = "Lector"
                        },
                        new
                        {
                            Id = 2,
                            Email = "viktor.bolshov@mail.ru",
                            FirstName = "Viktor",
                            LastName = "Bolshov",
                            Position = "Main lector"
                        },
                        new
                        {
                            Id = 3,
                            Email = "vlad.gryaznov@mail.ru",
                            FirstName = "Vlad",
                            LastName = "Gryaznov",
                            Position = "Lector"
                        });
                });

            modelBuilder.Entity("DatabaseAccess.Models.LectureDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("LectorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LectorId");

                    b.ToTable("Lectures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2021, 11, 3, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            LectorId = 2,
                            Name = "Docker"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2021, 11, 14, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            LectorId = 3,
                            Name = "SOLID"
                        });
                });

            modelBuilder.Entity("DatabaseAccess.Models.MarkDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LectureId")
                        .HasColumnType("int");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LectureId");

                    b.HasIndex("StudentId");

                    b.ToTable("Marks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LectureId = 1,
                            Mark = 4,
                            StudentId = 2,
                            Text = "Little mistakes"
                        },
                        new
                        {
                            Id = 2,
                            LectureId = 2,
                            Mark = 5,
                            StudentId = 2,
                            Text = "Great work"
                        },
                        new
                        {
                            Id = 3,
                            LectureId = 1,
                            Mark = 3,
                            StudentId = 1,
                            Text = "Too simple"
                        },
                        new
                        {
                            Id = 4,
                            LectureId = 2,
                            Mark = 5,
                            StudentId = 1,
                            Text = "Great work"
                        },
                        new
                        {
                            Id = 5,
                            LectureId = 1,
                            Mark = 0,
                            StudentId = 3,
                            Text = "Didn't come to lecture"
                        },
                        new
                        {
                            Id = 6,
                            LectureId = 2,
                            Mark = 5,
                            StudentId = 3,
                            Text = "Great work"
                        });
                });

            modelBuilder.Entity("DatabaseAccess.Models.StudentDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 24,
                            Email = "oleg.leskov@mail.ru",
                            FirstName = "Oleg",
                            LastName = "Leskov",
                            Score = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            Email = "ivan.ivanovich@mail.ru",
                            FirstName = "Ivan",
                            LastName = "Ivanovich",
                            Score = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            Email = "egor.sizlov@mail.ru",
                            FirstName = "Egor",
                            LastName = "Sizlov",
                            Score = 0
                        });
                });

            modelBuilder.Entity("DatabaseAccess.Models.AttendanceDb", b =>
                {
                    b.HasOne("DatabaseAccess.Models.LectureDb", "Lecture")
                        .WithMany("Attendances")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseAccess.Models.StudentDb", "Student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecture");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DatabaseAccess.Models.HomeworkDb", b =>
                {
                    b.HasOne("DatabaseAccess.Models.LectureDb", "Lecture")
                        .WithOne("Homework")
                        .HasForeignKey("DatabaseAccess.Models.HomeworkDb", "LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecture");
                });

            modelBuilder.Entity("DatabaseAccess.Models.LectureDb", b =>
                {
                    b.HasOne("DatabaseAccess.Models.LectorDb", "Lector")
                        .WithMany("Lectures")
                        .HasForeignKey("LectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lector");
                });

            modelBuilder.Entity("DatabaseAccess.Models.MarkDb", b =>
                {
                    b.HasOne("DatabaseAccess.Models.LectureDb", "Lecture")
                        .WithMany()
                        .HasForeignKey("LectureId");

                    b.HasOne("DatabaseAccess.Models.StudentDb", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecture");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DatabaseAccess.Models.LectorDb", b =>
                {
                    b.Navigation("Lectures");
                });

            modelBuilder.Entity("DatabaseAccess.Models.LectureDb", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Homework")
                        .IsRequired();
                });

            modelBuilder.Entity("DatabaseAccess.Models.StudentDb", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Marks");
                });
#pragma warning restore 612, 618
        }
    }
}
