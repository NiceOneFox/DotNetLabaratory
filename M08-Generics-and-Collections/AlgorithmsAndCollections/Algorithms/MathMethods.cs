using System.Collections.Generic;

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
                try
                {
                    nextNumber = checked(prevNumber + number);
                }
                catch (System.OverflowException ex)
                {
                    // log
                    throw ex;
                }

                yield return prevNumber;

                prevNumber = number;
                number = nextNumber;
            }
        }
    }
}
