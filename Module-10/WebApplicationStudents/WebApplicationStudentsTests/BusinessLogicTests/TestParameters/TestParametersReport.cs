using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationStudentsTests.BusinessLogicTests.TestParameters
{
    public static class TestParametersReport
    {
        public static IEnumerable<object> collectionCase1 = new[] {
        new { FirstName = "Ivan", LastName = "Ivanovich", Email = "ivan.ivanovich@mail.ru", LectureName = "Docker", LectureDate = "03.11.2021 16:00:00", Attendance = true },
        new { FirstName = "Ivan", LastName = "Ivanovich", Email = "ivan.ivanovich@mail.ru", LectureName = "Docker", LectureDate = "03.11.2021 16:00:00", Attendance = true },
        new { FirstName = "Ivan", LastName = "Ivanovich", Email = "ivan.ivanovich@mail.ru", LectureName = "Design Patterns", LectureDate = "08.12.2021 16:00:00", Attendance = false },
        new { FirstName = "Ivan", LastName = "Ivanovich", Email = "ivan.ivanovich@mail.ru", LectureName = "Machine Learning", LectureDate = "04.12.2021 18:00:00", Attendance = true },
        new { FirstName = "Ivan", LastName = "Ivanovich", Email = "ivan.ivanovich@mail.ru", LectureName = "Graphics", LectureDate = "23.12.2021 18:00:00", Attendance = true },
        };

        public static IEnumerable<object> collectionCase2;

        public static object[] ReportCollectionCases =
        {
            new object[] { "student", "Ivan", collectionCase1},
            new object[] { "lecture", "Docker", collectionCase2}
        };

    }
}
