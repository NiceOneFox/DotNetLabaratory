using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Moq;
using DatabaseAccess.Repository;
using Microsoft.EntityFrameworkCore;
using DatabaseAccess;
using Microsoft.EntityFrameworkCore.InMemory;
using System.Linq;
using DatabaseAccess.Configuration;
using AutoMapper;
using BusinessLogic.Models;
using DatabaseAccess.Models;
using BusinessLogic.Services;
using BusinessLogic.Mappers;

namespace WebApplicationStudentsTests.BusinessLogicTests
{
    class StudentServiceTests
    {
        private CourseDbContext _context { get; set; }
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<CourseDbContext>()
                .UseInMemoryDatabase(databaseName: "CourseDb")
                .Options;

            _context = new CourseDbContext(options);
            
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

        public void Delete_UnexistingId_ThrowsException()
        {

        }
    }
}

