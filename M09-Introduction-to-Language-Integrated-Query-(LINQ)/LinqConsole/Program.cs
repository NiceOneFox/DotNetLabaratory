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
            var student = new Student("Ivan Petrov", "Maths", DateTime.Parse("25/11/2012"),  4);

            List<Student> allStudents = new List<Student>();
            allStudents.Add(student);
            allStudents.Add(new Student())

            var jsonString = JsonSerializer.Serialize(allStudents);

            File.WriteAllText(
                @"C:\Users\Eugene\Documents\GitHub\EpamLaboratoryProjects\M01-Introduction-To-The-Language\M09-Introduction-to-Language-Integrated-Query-(LINQ)\LinqConsole\Data\StudentsData.json", jsonString);
        }
    }
}
