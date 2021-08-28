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

            for (int i = 0; i < first.Length; i++)
            {
                newString.Append(first[i]);
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j] && second[j] != ' ')
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
