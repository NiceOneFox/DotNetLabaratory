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
            long a = Process.GetCurrentProcess().PrivateMemorySize64;

            Console.WriteLine(a);

            //Random random = new Random();

            //C[] classes = new C[100000];
            //for (int i = 0; i < 10000; i++)
            //{
            //    classes[i].i = random.Next();
            //}

            //S[] structs = new S[100000];
            //for (int i = 0; i < 10000; i++)
            //{
            //    structs[i].i = random.Next();

            }
    }
}
