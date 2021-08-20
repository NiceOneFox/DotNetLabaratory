using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        public static IEnumerable<string> GetRandomSubjects(string[] subjects)
        {
            List<string> list = new List<string>();

            int maxSizeIndex = 5;

            bool[] isUsedValue = new bool[maxSizeIndex]; // flags to indicate if value was used
            Random random = new Random();

            while (list.Count != 3)
            {
                int index = random.Next(0, maxSizeIndex);
                if (!isUsedValue[index])
                {
                    list.Add(subjects[index]); // add value
                    isUsedValue[index] = true; // set flag
                }
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
