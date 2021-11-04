using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Moq;
using DatabaseAccess.Repository;
using Microsoft.EntityFrameworkCore;
using DatabaseAccess;
using System.Linq;
using AutoMapper;
using BusinessLogic.Models;
using DatabaseAccess.Models;
using BusinessLogic.Services;
using BusinessLogic.Mappers;
using CourseExceptions;
using WebApplicationStudentsTests.BusinessLogicTests.TestParameters;

namespace WebApplicationStudentsTests.BusinessLogicTests
{
    [TestFixture]
    public class StudentServiceTests
    {
        private CourseDbContext _context { get; set; }
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<CourseDbContext>()
                .UseInMemoryDatabase(databaseName: "CourseDb")
                .Options;

            _context = new CourseDbContext(options);

            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }

        [Test]
        public void Delete_ExistingId_ReturnsStudent()
        {
            //arrange

            int expectedCountStudents = _context.Students.Count() - 1;
            int id = 1;

            IStudentRepository studentRepository = new StudentRepository(_context);

            var myProfile = new MapperBl();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));
            IMapper mapper = new Mapper(configuration);

            var studentService = new StudentService(studentRepository, mapper);
            // act
            studentService.Delete(id);
            int countStudent = _context.Students.Count();

            //assert
            Assert.AreEqual(expectedCountStudents, countStudent);
        }

        [Test]
        public void Delete_UnexistingId_ThrowsException()
        {
            //arrange
            int notExistingId = -34;

            IStudentRepository studentRepository = new StudentRepository(_context);

            var myProfile = new MapperBl();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));
            IMapper mapper = new Mapper(configuration);

            var studentService = new StudentService(studentRepository, mapper);

            // act
            TestDelegate act = () => studentService.Delete(notExistingId);

            //assert
            try
            {
                Assert.Throws<NotFoundInstanceException>(act);
            }
            catch (NotFoundInstanceException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void Edit_ExistingStudent_ChangedStudentModel()
        {
            //arrange
            IStudentRepository studentRepository = new StudentRepository(_context);

            var myProfile = new MapperBl();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));
            IMapper mapper = new Mapper(configuration);

            var studentService = new StudentService(studentRepository, mapper);

            var studentUnedited = mapper.Map<StudentBl>(_context.Students.FirstOrDefault());
            var expectedStudent = studentUnedited with { FirstName = "TESTED" };
            //act

            var actualEditedStudent = studentService.Edit(expectedStudent);

            //assert
            Assert.AreEqual(expectedStudent, actualEditedStudent);
        }

        [Test]
        public void Edit_UnexistingStudent_ThrowsExceptions()
        {
            //arrange           
            IStudentRepository studentRepository = new StudentRepository(_context);

            var myProfile = new MapperBl();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));
            IMapper mapper = new Mapper(configuration);

            var studentService = new StudentService(studentRepository, mapper);

            var studentUnedited = mapper.Map<StudentBl>(_context.Students.FirstOrDefault());
            var expectedStudent = studentUnedited with { Id = -34 }; //unexisting primary key
            // act
            TestDelegate act = () => studentService.Edit(expectedStudent);

            //assert
            try
            {
                Assert.Throws<NotFoundInstanceException>(act);
            }
            catch (NotFoundInstanceException)
            {
                Assert.Pass();
            }
        }

        [Test]
        [TestCaseSource(typeof(TestParametersStudent), nameof(TestParametersStudent.TestStudentBl))]
        public void Get_ExistingId_ReturnsStudent(int id, StudentBl expectedStudentBl)
        {
            //arrange
            IStudentRepository studentRepository = new StudentRepository(_context);

            var myProfile = new MapperBl();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));
            IMapper mapper = new Mapper(configuration);

            var studentService = new StudentService(studentRepository, mapper);

            //act
            var actualStudent = studentService.Get(id);

            //assert
            Assert.AreEqual(expectedStudentBl, actualStudent);

        }

        [Test]
        public void Get_UnexistingId_ReturnsNull()
        {
            //arrange
            IStudentRepository studentRepository = new StudentRepository(_context);

            var myProfile = new MapperBl();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));
            IMapper mapper = new Mapper(configuration);

            var studentService = new StudentService(studentRepository, mapper);

            var expectedStudent = mapper.Map<StudentBl>(
                new StudentDb
                {
                    Id = 1,
                    FirstName = "Oleg",
                    LastName = "Leskov",
                    Age = 24,
                    Email = "oleg.leskov@mail.ru",
                    Telephone = "+7(566)534-96-53",
                    Score = 0
                });

            int unexistingId = -34;

            //act
            var actualStudent = studentService.Get(unexistingId);

            //assert
            Assert.Null(actualStudent);
        }

        [Test]
        public void GetAll_ReturnsCollectionStudents()
        {
            //arrange
            IStudentRepository studentRepository = new StudentRepository(_context);

            var myProfile = new MapperBl();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));
            IMapper mapper = new Mapper(configuration);

            var studentService = new StudentService(studentRepository, mapper);


            var expectedStudents = mapper.Map<IReadOnlyCollection<StudentBl>>(
                 new StudentDb[]
                 {
                    new StudentDb { Id = 1, FirstName = "Oleg", LastName = "Leskov", Age = 24, Email = "oleg.leskov@mail.ru", Telephone = "+7(566)534-96-53", Score = 0 },
                    new StudentDb { Id = 2, FirstName = "Ivan", LastName = "Ivanovich", Age = 22, Email = "ivan.ivanovich@mail.ru", Telephone = "+7(866)735-46-33", Score = 0 },
                    new StudentDb { Id = 3, FirstName = "Egor", LastName = "Sizlov", Age = 21, Email = "egor.sizlov@mail.ru", Telephone = "+7(924)873-01-42", Score = 0 }
                 });
                                           

            //act
            var actualCollection = studentService.GetAll();

            //assert
            CollectionAssert.AllItemsAreUnique(actualCollection);
            CollectionAssert.AreEqual(expectedStudents, actualCollection);
        }

        [Test]
        public void New_CorrectStudent_ReturnIdContext()
        {
            //arrange 
            IStudentRepository studentRepository = new StudentRepository(_context);

            IMapper mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBl())));

            var studentService = new StudentService(studentRepository, mapper);

            StudentBl studentBl = new StudentBl() { Id = 4, FirstName = "Oleg", LastName = "Valeryanov", Age = 26, Email = "oleg.valeryanov@mail.ru", Telephone = "+7(566)354-96-53", Score = 0 };

            //act
            int contextId = studentService.New(studentBl);

            //assert
            StudentDb actualStudent = _context.Students.Find(studentBl.Id);
            Assert.NotNull(actualStudent);
            Assert.AreEqual(contextId, actualStudent.Id);
        }

    }
}

