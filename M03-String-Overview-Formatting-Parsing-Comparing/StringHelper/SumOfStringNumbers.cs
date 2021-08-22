using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHelper
{
    public static class SumOfStringNumbers
    {
        /// <summary>
        /// Sum two string represented long numbers
        /// </summary>
        /// <param name="first">first operand</param>
        /// <param name="second">second operand</param>
        /// <returns>String which contains very big number</returns>
        public static string SumOfTwoLongNumbers(string first, string second)
        {
            //StringBuilder result = new StringBuilder();
            char[] result = new char[Math.Max(first.Length, second.Length) + 1];

            char overFlowDigit = '0';
            char secondDigit = '0';

            for (int i = first.Length - 1, k = second.Length - 1, j = 0; i >= 0 && k >= 0; i--, k--, j++) 
            {
                int tempInt = (int)(first[i] - '0') + (int)(second[k] - '0'); // 5 7  = 12

                tempInt += (int)(overFlowDigit - '0');

                overFlowDigit = tempInt.ToString().First(); // 5

                secondDigit = tempInt.ToString().Last(); // second digit + oveflow digit                      

              //  result.Append(secondDigit); // take only last digit and save first
                result[j] = secondDigit;
                if (i == 1 || k == 1)
                {
                    // result.Append(overFlowDigit);
                    j++;
                    result[j] = overFlowDigit;
                }
            }

           // return result.ToString();
            return new string(result);
        }
    }
}
