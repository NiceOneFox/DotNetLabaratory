using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        public static IEnumerable<string> GetRandomSubjects(string[] subjects)
        {
            List<string> list = new List<string>();

            Random random = new Random();
            int maxSize = 5;

            for (int i = 0; i < 3; i++)
            {
                list.Add(subjects[random.Next(0, maxSize)]);
            }

            return list;
        }
        static void Main(string[] args)
        {
            string[] subjects = {"Math", "Physics", "Biology", "Chemistry", "PE", "English"};

            var student1c1 = new Student("Egor.Kanetskin@epam.com");
            var student2c1 = new Student("Ivan.Vasiliev@epam.com");
            var student3c1 = new Student("Irina.Voznesenkaya@epam.com");

            var student1c2 = new Student("Egor", "Kanetskin");
            var student2c2 = new Student("Ivan", "Vasiliev");
            var student3c2 = new Student("Irina", "Voznesenkaya");

            var studentSubjectDict = new Dictionary<Student, HashSet<string>>();

            studentSubjectDict.Add(student1c1, new HashSet<string>(GetRandomSubjects(subjects)));
            studentSubjectDict.Add(student2c1, new HashSet<string>(GetRandomSubjects(subjects)));
            studentSubjectDict.Add(student3c1, new HashSet<string>(GetRandomSubjects(subjects)));
            studentSubjectDict.Add(student1c2, new HashSet<string>(GetRandomSubjects(subjects)));
            studentSubjectDict.Add(student2c2, new HashSet<string>(GetRandomSubjects(subjects)));
            studentSubjectDict.Add(student3c2, new HashSet<string>(GetRandomSubjects(subjects)));

            Console.WriteLine(studentSubjectDict.Count);
        }
    }
}
