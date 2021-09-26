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

            List<Student> sortedStudents  = new List<Student>();

            Dictionary<string, Func<List<Student>, string>> keyValuePairs = new Dictionary<string, Func<List<Student>, string>>();




            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
                   {

                       string unparsedArgs = CommandLine.Parser.Default.FormatCommandLine(o, config => config.SkipDefault = true);

                       Console.WriteLine(unparsedArgs);

                       if (unparsedArgs.Contains(o.NameStudent))
                       {
                           sortedStudents = (from s in allStudents
                                             where s.Name.Equals(o.NameStudent)
                                             select s //new Student(s.Name, s.TestName, s.Date, s.Assesment)                                     
                                          ).ToList();


                           Console.WriteLine("Name student sort: " + o.NameStudent);
                       }
                       

                       if (o.MaxMark is not null)
                       {
                           sortedStudents = (from s in sortedStudents
                                             where s.Assesment <= o.MaxMark
                                             select s).ToList();

                           Console.WriteLine("Max mark sort:" + o.MaxMark);
                       }

                       if (o.MinMark is not null)
                       {
                           sortedStudents = (from s in sortedStudents
                                              where s.Assesment >= o.MinMark
                                              select s).ToList();

                           Console.WriteLine("Min mark sort:" + o.MinMark);
                       }

                       if (o.DateFrom is not null)
                       {
                           sortedStudents = (from s in sortedStudents
                                              where s.Date >= o.DateFrom
                                              select s).ToList();
                           Console.WriteLine("Date from sort:" + o.DateFrom);
                       }

                       if (o.DateTo is not null)
                       {
                           sortedStudents = (from s in sortedStudents
                                              where s.Date <= o.DateTo
                                              select s).ToList();
                           Console.WriteLine("Date to sort:" + o.DateTo);
                       }

                       if (o.TestName is not null)
                       { 
                           sortedStudents = (from s in sortedStudents
                                              where s.TestName == o.TestName
                                              select s).ToList();
                           Console.WriteLine("Test name:" + o.TestName);
                       }

                       //sortedStudents.Sort();

                       //foreach (var prop in typeof(Options).GetProperties())
                       //{                          
                       //    if (ConsoleParser.ConsoleParser.IsSetByUser(o, prop.Name.ToLower())){
                       //        Console.WriteLine(prop.Name + "prop name");
                       //    }
                       //}
                      
                       foreach (var stud in sortedStudents)
                       {
                           Console.WriteLine(stud.Name + " " + stud.Date + " " + stud.TestName + " " + stud.Assesment);
                       }

                   });


        }
    }
}
