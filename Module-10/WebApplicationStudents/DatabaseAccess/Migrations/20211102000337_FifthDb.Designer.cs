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
    [Migration("20211102000337_FifthDb")]
    partial class FifthDb
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

                    b.Property<bool>("IsAttend")
                        .HasColumnType("bit");

                    b.HasKey("LectureId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendances");

                    b.HasData(
                        new
                        {
                            LectureId = 1,
                            StudentId = 1,
                            IsAttend = true
                        },
                        new
                        {
                            LectureId = 2,
                            StudentId = 1,
                            IsAttend = true
                        },
                        new
                        {
                            LectureId = 3,
                            StudentId = 1,
                            IsAttend = false
                        },
                        new
                        {
                            LectureId = 4,
                            StudentId = 1,
                            IsAttend = true
                        },
                        new
                        {
                            LectureId = 5,
                            StudentId = 1,
                            IsAttend = true
                        },
                        new
                        {
                            LectureId = 1,
                            StudentId = 2,
                            IsAttend = true
                        },
                        new
                        {
                            LectureId = 2,
                            StudentId = 2,
                            IsAttend = false
                        },
                        new
                        {
                            LectureId = 3,
                            StudentId = 2,
                            IsAttend = false
                        },
                        new
                        {
                            LectureId = 4,
                            StudentId = 2,
                            IsAttend = true
                        },
                        new
                        {
                            LectureId = 5,
                            StudentId = 2,
                            IsAttend = true
                        },
                        new
                        {
                            LectureId = 1,
                            StudentId = 3,
                            IsAttend = true
                        },
                        new
                        {
                            LectureId = 2,
                            StudentId = 3,
                            IsAttend = true
                        },
                        new
                        {
                            LectureId = 3,
                            StudentId = 3,
                            IsAttend = true
                        },
                        new
                        {
                            LectureId = 4,
                            StudentId = 3,
                            IsAttend = true
                        },
                        new
                        {
                            LectureId = 5,
                            StudentId = 3,
                            IsAttend = false
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
                        },
                        new
                        {
                            Id = 3,
                            DeadLine = new DateTime(2021, 12, 16, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            LectureId = 3,
                            Text = "Ex. 24. First Paragraph"
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

                    b.Property<int>("SeriesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lectors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "irina.vlasova@mail.ru",
                            FirstName = "Irina",
                            LastName = "Vlasova",
                            Position = "Lector",
                            SeriesId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "viktor.bolshov@mail.ru",
                            FirstName = "Viktor",
                            LastName = "Bolshov",
                            Position = "Main lector",
                            SeriesId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "vlad.gryaznov@mail.ru",
                            FirstName = "Vlad",
                            LastName = "Gryaznov",
                            Position = "Lector",
                            SeriesId = 3
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

                    b.Property<int>("HomeworkId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeriesId");

                    b.ToTable("Lectures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2021, 11, 3, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            HomeworkId = 1,
                            Name = "Docker",
                            SeriesId = 2
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2021, 11, 14, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            HomeworkId = 2,
                            Name = "SOLID",
                            SeriesId = 3
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2021, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            HomeworkId = 3,
                            Name = "Design Patterns",
                            SeriesId = 1
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2021, 12, 4, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            HomeworkId = 2,
                            Name = "Machine Learning",
                            SeriesId = 3
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2021, 12, 23, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            HomeworkId = 2,
                            Name = "Graphics",
                            SeriesId = 1
                        });
                });

            modelBuilder.Entity("DatabaseAccess.Models.MarkDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LectureId")
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

            modelBuilder.Entity("DatabaseAccess.Models.SeriesDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("LectorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LectorId")
                        .IsUnique();

                    b.ToTable("SeriesDb");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LectorId = 1,
                            Name = "Base Course of Algorithms and Programming"
                        },
                        new
                        {
                            Id = 2,
                            LectorId = 2,
                            Name = "Middle Course of C# programming"
                        },
                        new
                        {
                            Id = 3,
                            LectorId = 3,
                            Name = "Advanced course of Algorithms and ML"
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

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            Score = 0,
                            Telephone = "+7(566)534-96-53"
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            Email = "ivan.ivanovich@mail.ru",
                            FirstName = "Ivan",
                            LastName = "Ivanovich",
                            Score = 0,
                            Telephone = "+7(866)735-46-33"
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            Email = "egor.sizlov@mail.ru",
                            FirstName = "Egor",
                            LastName = "Sizlov",
                            Score = 0,
                            Telephone = "+7(924)873-01-42"
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
                    b.HasOne("DatabaseAccess.Models.SeriesDb", "Series")
                        .WithMany("Lectures")
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Series");
                });

            modelBuilder.Entity("DatabaseAccess.Models.MarkDb", b =>
                {
                    b.HasOne("DatabaseAccess.Models.LectureDb", "Lecture")
                        .WithMany()
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseAccess.Models.StudentDb", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecture");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DatabaseAccess.Models.SeriesDb", b =>
                {
                    b.HasOne("DatabaseAccess.Models.LectorDb", "Lector")
                        .WithOne("Series")
                        .HasForeignKey("DatabaseAccess.Models.SeriesDb", "LectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lector");
                });

            modelBuilder.Entity("DatabaseAccess.Models.LectorDb", b =>
                {
                    b.Navigation("Series")
                        .IsRequired();
                });

            modelBuilder.Entity("DatabaseAccess.Models.LectureDb", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Homework")
                        .IsRequired();
                });

            modelBuilder.Entity("DatabaseAccess.Models.SeriesDb", b =>
                {
                    b.Navigation("Lectures");
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
