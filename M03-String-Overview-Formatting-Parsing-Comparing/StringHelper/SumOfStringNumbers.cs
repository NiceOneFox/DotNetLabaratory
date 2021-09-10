using System;

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
            if (first == null || second == null)
            {
                return "0";
            }

            char[] result = new char[Math.Max(first.Length, second.Length) + 1];

            char overFlowDigit = '0';
            char secondDigit = '0';
            int tempInt = 0;

            for (int i = first.Length - 1, k = second.Length - 1, j = result.Length - 1; j != 0; i--, k--, j--)
            {
                if (i >= 0 && k >= 0)
                {
                    tempInt = CharDigitToInt(first[i]) + CharDigitToInt(second[k]); // 5 7  = 12
                }
                if (i < 0)
                {
                    tempInt = CharDigitToInt(second[k]);
                }
                if (k < 0)
                {
                    tempInt = CharDigitToInt(first[i]);
                }

                tempInt += CharDigitToInt(overFlowDigit);

                string tempString = tempInt.ToString();

                if (tempString.Length == 2)
                {
                    overFlowDigit = tempString[0];
                    secondDigit = tempString[1]; // second digit + oveflow digit       
                }
                else
                {
                    secondDigit = tempString[0];
                    overFlowDigit = '0';
                }

                result[j] = secondDigit;
            }

            return new string(result).Replace("\0", string.Empty);
        }

        private static int CharDigitToInt(Char c)
        {
            return c - '0';
        }

    }
}
