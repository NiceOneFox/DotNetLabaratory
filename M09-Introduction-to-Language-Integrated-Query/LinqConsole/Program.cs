using LinqConsole.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CommandLine;
using System.Linq;

namespace LinqConsole
{
    public class Program
    {

        public static void Main(string[] args) //-name Ivan - minmark 3 - maxmark 5 - datefrom 20 / 11 / 2012 - dateto 20 / 12 / 2012 - test Maths
        {   
            var dataAdapter = new DataAdapter.DataAdapter(@"C:\Users\Eugene\Documents\GitHub\EpamLaboratoryProjects\EPAM\M09-Introduction-to-Language-Integrated-Query\LinqConsole\Data\StudentsData.json");

            List<Student> allStudents = dataAdapter.RetrieveDataFromJSON();

            // string testString = "-s Grisha-Ivanov -m 5 -l 3 -r Assesment asc";

            List<Student> sortedStudents = CommandLineParserLINQ.ParseArguments(args, allStudents);

            foreach (var stud in sortedStudents)
            {
                Console.WriteLine(stud.Name + " " + stud.Date + " " + stud.TestName + " " + stud.Assesment);
            }

        }
    }
}
