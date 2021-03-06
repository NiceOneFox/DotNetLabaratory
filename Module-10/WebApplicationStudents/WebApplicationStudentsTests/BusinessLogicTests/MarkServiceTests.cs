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
using Twilio.Clients;

namespace WebApplicationStudentsTests.BusinessLogicTests
{
    public class MarkServiceTests
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
        public void Delete_ExistingId_ReturnsMark()
        {
            //arrange
            int expectedCountMark = _context.Marks.Count() - 1;
            int id = 1;

            var markRepository = new MarkRepository(_context);

            var mockStudentRepository = new Mock<IStudentRepository>();
            var mockTwilioRestClient = new Mock<ITwilioRestClient>();

            IMapper mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBl())));
            
            var markService = new MarkService(markRepository, mockStudentRepository.Object,
                mapper, mockTwilioRestClient.Object);

            //act

            markService.Delete(id);

            //assert
            Assert.AreEqual(expectedCountMark, _context.Marks.Count());
        }

        [Test]
        public void Delete_UnexistingId_ThrowsException()
        {
            //arrange
            int expectedCountMark = _context.Marks.Count();
            int unexistingId = -34;

            var markRepository = new MarkRepository(_context);

            var mockStudentRepository = new Mock<IStudentRepository>();
            var mockTwilioRestClient = new Mock<ITwilioRestClient>();

            IMapper mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBl())));

            var markService = new MarkService(markRepository, mockStudentRepository.Object,
                mapper, mockTwilioRestClient.Object);

            //act
            TestDelegate act = () => markService.Delete(unexistingId);

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
        public void Edit_ExistingMark_ChangedMarkModel()
        {
            //arrange            
            MarkBl expectedEditedMark = new MarkBl { Id = 2, Assesment = 2, Text = "Little mistakes", LectureId = 1, StudentId = 2 };

            var markRepository = new MarkRepository(_context);

            var mockStudentRepository = new Mock<IStudentRepository>();
            var mockTwilioRestClient = new Mock<ITwilioRestClient>();

            IMapper mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBl())));

            var markService = new MarkService(markRepository, mockStudentRepository.Object,
                mapper, mockTwilioRestClient.Object);

            //act
            var actualMarkBl = markService.Edit(expectedEditedMark);
            //assert
            Assert.AreEqual(expectedEditedMark, actualMarkBl);
        }

        [Test]
        public void Edit_UnexistingMark_ThrowsException()
        {
            //arrange
            var markRepository = new MarkRepository(_context);

            var mockStudentRepository = new Mock<IStudentRepository>();
            var mockTwilioRestClient = new Mock<ITwilioRestClient>();

            IMapper mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBl())));

            var markService = new MarkService(markRepository, mockStudentRepository.Object,
                mapper, mockTwilioRestClient.Object);

            MarkBl fakeMarkBl = new MarkBl() { Id = 999, Assesment = 3, LectureId = 3, StudentId = 4, Text = "Some text" };
            //act

            TestDelegate act = () => markService.Edit(fakeMarkBl);

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

        public void New_ExistingMark_ContextId()
        {
            // arrange
            var markRepository = new MarkRepository(_context);

            var mockStudentRepository = new Mock<IStudentRepository>();
            var mockTwilioRestClient = new Mock<ITwilioRestClient>();

            IMapper mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBl())));

            var markService = new MarkService(markRepository, mockStudentRepository.Object,
                mapper, mockTwilioRestClient.Object);

            MarkBl newMark = new MarkBl() { LectureId = 2, StudentId = 3, Assesment = 4, Text = "Some text" };
           
            //act
            int contextId = markService.New(newMark);

            //assert
            MarkDb actualMark = _context.Marks.Find(newMark.Id);
            Assert.NotNull(actualMark);
            Assert.AreEqual(contextId, actualMark.Id);
        }

    }
}
