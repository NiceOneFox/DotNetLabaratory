using System;
using System.Diagnostics;

namespace Perfomance
{

    class Program
    {
        static void Main(string[] args)
        {
            // I am using .NET 5 so Diagnostics.PrivateMemorySize64 was deprecated
            Random random = new Random();

            C[] classes = new C[100000];
            for (int i = 0; i < 10000; i++)
            {
                classes[i].i = random.Next();
            }

            S[] structs = new S[100000];
            for (int i = 0; i < 10000; i++)
            {
                structs[i].i = random.Next();
            }


        }
    }
}
