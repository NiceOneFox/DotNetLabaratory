using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = {"Math", "Physics", "Biology", "Chemistry", "PE", "English"};

            var student1 = new Student("Egor.Kanetskin@epam.com");
            var student2 = new Student("Ivan.Vasiliev@epam.com");
            var student3 = new Student("Irina.Voznesenkaya@epam.com");

            var student4 = new Student("Evgenii", "Venskii");
            var student5 = new Student("Lena", "Morskaya");
            var student6 = new Student("Dima", "Kilnov");

            Console.WriteLine("234635");
        }
    }
}
