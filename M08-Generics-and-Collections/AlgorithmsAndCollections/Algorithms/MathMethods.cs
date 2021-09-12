using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndCollections
{
    public class MathMethods
    {
        public IEnumerable<int> Fibonacci()
        {
            int prevNumber = 0;
            int number = 1;
            int nextNumber;

            for (int i = 0; ; i++)
            {               
                if (i == 47) // next number will have overflow. Greater than int.MaxValue
                {
                    yield break;
                }

                nextNumber = prevNumber + number;             
                
                yield return prevNumber;

                prevNumber = number;
                number = nextNumber;
            }         
        }
    }
}
