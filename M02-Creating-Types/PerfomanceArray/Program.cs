using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PerfomanceArray
{
    class Program
    {
        static void Main(string[] args)
        {
            long entryMemory = Process.GetCurrentProcess().PrivateMemorySize64;
            Console.WriteLine(entryMemory);

            Random random = new Random();

            C[] classes = new C[100000];

            for (int i = 0; i < 10000; i++)
            {
                classes[i] = new C(random.Next());
            }

            long classesMemory = Process.GetCurrentProcess().PrivateMemorySize64;
            long firstDelta = classesMemory - entryMemory;
            Console.WriteLine($"Memory after init classes: {firstDelta}");

            S[] structs = new S[100000];
            for (int i = 0; i < 10000; i++)
            {
                structs[i] = new S(random.Next());

            }

            long structsMemory = Process.GetCurrentProcess().PrivateMemorySize64;
            long secondDelta = structsMemory - firstDelta - entryMemory;
            Console.WriteLine($"Memory after init structs: {secondDelta}");

            Console.WriteLine($"differnce between classes memory used and structs are " +
                $"{Math.Abs(secondDelta - firstDelta)}");
            
        }
    }
}
