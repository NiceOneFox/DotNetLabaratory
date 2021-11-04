using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using DatabaseAccess.Repository;
using Microsoft.EntityFrameworkCore;
using DatabaseAccess;
using AutoMapper;
using BusinessLogic.Models;
using DatabaseAccess.Models;
using BusinessLogic.Services;
using BusinessLogic.Mappers;
using CourseExceptions;
using DatabaseAccess.RepositoryInterfaces;
using BusinessLogic.EmailSender;
using WebApplicationStudentsTests.BusinessLogicTests.TestParameters;

namespace WebApplicationStudentsTests.BusinessLogicTests
{
    public class AttendanceServiceTests
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

        [TestCaseSource(typeof(TestParameters.TestParametersReport), nameof(TestParameters.TestParametersReport.ReportCollectionCases))]
        public void GetReportOfAttendance_CorrectInput_ReturnsCollection(string orderby, string name, 
            IReadOnlyCollection<object> expectedCollection)
        {
            //arrange
            IAttendanceRepository attendanceRepository = new AttendanceRepository(_context);
            var mockStudentRepository = new Mock<IStudentRepository>();
            var mockEmailService = new Mock<IEmailService>();      
            var mockMapper = new Mock<IMapper>();

            var attendanceService = new AttendanceService(attendanceRepository, mockStudentRepository.Object,
                mockMapper.Object, mockEmailService.Object);


            //act
            var actualCollection = attendanceService.GetReportOfAttendance(orderby, name);
            //assert
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
            //have to use reflection or make class for output.
        }
    }
}
