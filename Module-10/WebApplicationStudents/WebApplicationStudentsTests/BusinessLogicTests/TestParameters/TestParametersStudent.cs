using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationStudentsTests.BusinessLogicTests.TestParameters
{
    public static class TestParametersStudent
    {
        public static object[] TestStudentBl =
        {
            new object[] { 1, new StudentBl { Id = 1, FirstName = "Oleg", LastName = "Leskov", Age = 24, Email = "oleg.leskov@mail.ru", Telephone = "+7(566)534-96-53", Score = 0 } },
            new object[] { 2, new StudentBl {Id = 2, FirstName = "Ivan", LastName = "Ivanovich", Age = 22, Email = "ivan.ivanovich@mail.ru", Telephone = "+7(866)735-46-33", Score = 0 } },
            new object[] { 3, new StudentBl {Id = 3, FirstName = "Egor", LastName = "Sizlov", Age = 21, Email = "egor.sizlov@mail.ru", Telephone = "+7(924)873-01-42", Score = 0 } }
        };

    }
}
