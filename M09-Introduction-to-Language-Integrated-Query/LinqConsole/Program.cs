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

        static void Main(string[] args) //-name Ivan - minmark 3 - maxmark 5 - datefrom 20 / 11 / 2012 - dateto 20 / 12 / 2012 - test Maths
        {
            string jsonString = File.ReadAllText(@"C:\Users\Eugene\Documents\GitHub\EpamLaboratoryProjects\M01-Introduction-To-The-Language\M09-Introduction-to-Language-Integrated-Query\LinqConsole\Data\StudentsData.json");
            List<Student> allStudents = JsonSerializer.Deserialize<List<Student>>(jsonString);

            List<Student> sortedStudents = new List<Student>();

            Parser.Default.ParseArguments<Options>(args) // ./LinqConsole -s Grisha-Ivanov -m 5 -l 3
                .WithParsed<Options>(o =>
                   {

                       sortedStudents = allStudents
                       .Where(x => (o.NameStudent is not null) ? x.Name == o.NameStudent  : true)
                       .Where(x => (o.MaxMark is not null)     ? x.Assesment <= o.MaxMark : true)
                       .Where(x => (o.MinMark is not null)     ? x.Assesment >= o.MinMark : true)
                       .Where(x => (o.DateFrom is not null)    ? x.Date >= o.DateFrom     : true)
                       .Where(x => (o.DateTo is not null)      ? x.Date <= o.DateTo       : true)
                       .Where(x => (o.TestName is not null)    ? x.TestName == o.TestName : true)
                       .ToList();


                       //Console.WriteLine("Name student sort: " + o.NameStudent);


                       //sortedStudents.Sort();

                       foreach (var stud in sortedStudents)
                       {
                           Console.WriteLine(stud.Name + " " + stud.Date + " " + stud.TestName + " " + stud.Assesment);
                       }

                   });


        }
    }
}
