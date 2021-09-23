using LinqConsole.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using CommandLine;

namespace LinqConsole
{
    class Program
    {
        public class Options
        {
            [Option('n', "namestudent", Required = true, HelpText = "Full name of the student")]

            public string NameStudent { get; set; }

            [Option('m', "minmark", Required = true, HelpText = "Min mark of student for sorting")]

            public int MaxMark { get; set; }
        }
        static void Main(string[] args) //-name Ivan - minmark 3 - maxmark 5 - datefrom 20 / 11 / 2012 - dateto 20 / 12 / 2012 - test Maths
        {
            string jsonString = File.ReadAllText(@"C:\Users\Eugene\Documents\GitHub\EpamLaboratoryProjects\M01-Introduction-To-The-Language\M09-Introduction-to-Language-Integrated-Query-(LINQ)\LinqConsole\Data\StudentsData.json");
            List<Student> allStudents = JsonSerializer.Deserialize<List<Student>>(jsonString);


            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                       Console.WriteLine(o.NameStudent + " " + o.MaxMark);
                   });


        }
    }
}
