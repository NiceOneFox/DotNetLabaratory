using NUnit.Framework;
using LinqConsole;
using LinqConsole.DataAdapter;
using LinqConsole.Models;
using System.Collections.Generic;
using System;

namespace LinqConsoleTests
{
    public class CommandLineParserLINQTests
    {

        [Test]
        public void CommandLineParserLINQ_NameMaxMarkMinMark_Expected2Students()
        {
            //Arrange
            string[] args = { "-s", "Grisha-Ivanov", "-m", "5", "-l", "3" };

            DataAdapter dataAdapter = new DataAdapter(@"C:\Users\Eugene\Documents\GitHub\EpamLaboratoryProjects\EPAM\M09-Introduction-to-Language-Integrated-Query\LinqConsole\Data\StudentsData.json");

            List<Student> allStudents = dataAdapter.RetrieveDataFromJSON();

            List<Student> expectedStudents = new List<Student>()
            {
                 new Student("Grisha Ivanov", "PE", DateTime.Parse("26/10/2012"), 5),
                 new Student("Grisha Ivanov", "Maths", DateTime.Parse("23/10/2012"), 4)
            };

            //Act
            var sortedStudents = CommandLineParserLINQ.ParseArguments(args, allStudents);

            //Assert
            Assert.That(expectedStudents, Is.EqualTo(sortedStudents));
        }

        public void CommandLineParserLINQ_ParametersAndSortByAssesment_Expected2Students()
        {
            //Arrange
            string[] args = { "-s", "Grisha-Ivanov", "-m", "5", "-l", "3", "-r", "Assesment", "asc" };

            DataAdapter dataAdapter = new DataAdapter(@"C:\Users\Eugene\Documents\GitHub\EpamLaboratoryProjects\EPAM\M09-Introduction-to-Language-Integrated-Query\LinqConsole\Data\StudentsData.json");

            List<Student> allStudents = dataAdapter.RetrieveDataFromJSON();

            List<Student> expectedStudents = new List<Student>()
            {                 
                 new Student("Grisha Ivanov", "Maths", DateTime.Parse("23/10/2012"), 4),
                 new Student("Grisha Ivanov", "PE", DateTime.Parse("26/10/2012"), 5)
            };

            //Act
            var sortedStudents = CommandLineParserLINQ.ParseArguments(args, allStudents);

            //Assert
            Assert.That(expectedStudents, Is.EqualTo(sortedStudents));
        }

        //[TestCase()]
        //public void CommandLineParserLINQ_CorrectInput(string filePath, List<Student> expectedStudents)
        //{
           
        //}
    }
}