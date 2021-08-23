using System;
using System.Diagnostics;

namespace PerfomanceArray
{
    public static class Program
    {
        static void Main(string[] args)
        {
            long entryMemory = Process.GetCurrentProcess().PrivateMemorySize64;
            Console.WriteLine(entryMemory);

            Random random = new Random();

            const int SIZE = 100000;

            C[] classes = new C[SIZE];

            for (int i = 0; i < SIZE; i++)
            {
                classes[i] = new C(random.Next());
            }

            long classesMemory = Process.GetCurrentProcess().PrivateMemorySize64;
            long firstDelta = classesMemory - entryMemory;
            Console.WriteLine($"Memory after init classes: {firstDelta}");

            S[] structs = new S[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                structs[i] = new S(random.Next());

            }

            long structsMemory = Process.GetCurrentProcess().PrivateMemorySize64;
            long secondDelta = structsMemory - firstDelta - entryMemory;
            Console.WriteLine($"Memory after init structs: {secondDelta}");

            Console.WriteLine($"differnce between classes memory used on classes and structs are " +
                $"{Math.Abs(secondDelta - firstDelta)} bytes ");


            //Calculate execution time
            var watch = Stopwatch.StartNew();

            Array.Sort(classes);

            watch.Stop();
            Console.WriteLine("Used time for sorting classes in ms: " + watch.ElapsedMilliseconds);

            watch.Restart();

            Array.Sort(structs);

            watch.Stop();
            Console.WriteLine("Used time for sorting structs in ms: " + watch.ElapsedMilliseconds);

        }
    }
}
