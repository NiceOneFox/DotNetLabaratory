using System;
using System.Collections.Generic;

namespace Students
{
    public static class Program
    {
        public static IEnumerable<string> GetRandomSubjects(string[] subjects)
        {
            List<string> allSubjects = new List<string>(subjects);

            List<string> list = new List<string>(); // random subjects output

            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                if (allSubjects.Count == 0)
                {
                    break;
                }

                int index = random.Next(0, allSubjects.Count);

                list.Add(allSubjects[index]); // add subject to output

                allSubjects.RemoveAt(index); // remove element from allSubjects
            }

            return list;
        }
        static void Main(string[] args)
        {
            try
            {
                string[] subjects = { "Math", "Physics", "Biology", "Chemistry", "PE", "English" };

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

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
