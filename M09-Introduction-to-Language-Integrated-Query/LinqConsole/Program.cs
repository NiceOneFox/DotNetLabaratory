using LinqConsole.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CommandLine;

namespace LinqConsole
{
    public class Program
    {
        static void Main(string[] args) //-name Ivan - minmark 3 - maxmark 5 - datefrom 20 / 11 / 2012 - dateto 20 / 12 / 2012 - test Maths
        {
            string jsonString = File.ReadAllText(@"C:\Users\Eugene\Documents\GitHub\EpamLaboratoryProjects\M01-Introduction-To-The-Language\M09-Introduction-to-Language-Integrated-Query\LinqConsole\Data\StudentsData.json");
            List<Student> allStudents = JsonSerializer.Deserialize<List<Student>>(jsonString);

            

            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
                   {
                       ConsoleParser.ConsoleParser.IsSetByUser(o, o.DateFrom.ToString());
                       //ConsoleParser.ConsoleParser.SortByName(allStudents, o.MaxMark.ToString());    
 
                   });


        }
    }
}
