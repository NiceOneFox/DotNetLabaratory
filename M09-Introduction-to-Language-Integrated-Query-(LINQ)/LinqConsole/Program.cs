using LinqConsole.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace LinqConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var student = new Student("Ivan Petrov", "Maths", DateTime.Parse("25/11/2012"),  4);

            //List<Student> allStudents = new List<Student>();
            //allStudents.Add(student);
            //allStudents.Add(new Student("Grisha Ivanov", "PE", DateTime.Parse("26/10/2012"), 5));
            //allStudents.Add(new Student("Grisha Ivanov", "Maths", DateTime.Parse("23/10/2012"), 4));
            //allStudents.Add(new Student("Lena Dinskaya", "English", DateTime.Parse("12/11/2012"), 3));
            //allStudents.Add(new Student("Lena Dinskaya", "Physics", DateTime.Parse("24/10/2012"), 4));


            //var jsonString = JsonSerializer.Serialize(allStudents);

            //File.WriteAllText(
            //    @"C:\Users\Eugene\Documents\GitHub\EpamLaboratoryProjects\M01-Introduction-To-The-Language\M09-Introduction-to-Language-Integrated-Query-(LINQ)\LinqConsole\Data\StudentsData.json", jsonString);
       
           string jsonString = File.ReadAllText(@"C:\Users\Eugene\Documents\GitHub\EpamLaboratoryProjects\M01-Introduction-To-The-Language\M09-Introduction-to-Language-Integrated-Query-(LINQ)\LinqConsole\Data\StudentsData.json");
           List<Student> allStudents = JsonSerializer.Deserialize<List<Student>>(jsonString);

            foreach (var stud in allStudents)
            {
                Console.WriteLine(stud.Date);
            }
           
            
        }
    }
}
