using System.Text;

namespace StringHelper
{
    public static class MultiplyCharater
    {
        /// <param name="first">first string</param>
        /// <param name="second">second string with characters to double</param>
        /// <returns>Double characters in first string which contains in second</returns>
        public static string DoubleCharacters(string first, string second)
        {
            StringBuilder newString = new StringBuilder(first.Length);

            for (int i = 0; i < first.Length; i++) // O(n) - n length of first string
            {
                newString.Append(first[i]); // O(1)
                for (int j = 0; j < second.Length; j++) // O(m)
                {
                    if (first[i] == second[j] && second[j] != ' ') // O(1)
                    {
                        newString.Append(first[i]); // double character if it contains in second string
                        break;
                    }
                }
            }

            return newString.ToString();
        }
    }

}
