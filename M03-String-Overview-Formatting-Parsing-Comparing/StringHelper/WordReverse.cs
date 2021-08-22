using System;

namespace StringHelper
{
    public static class WordReverse
    {
        /// <summary>
        /// Reverse all words in sentence
        /// </summary>
        /// <param name="sentence">input string</param>
        /// <returns>sentence with reversed word</returns>
        public static string Reverse(string sentence)
        {
            char[] result = new char[sentence.Length];

            bool isWordStarted = false;

            int startIndexOfWord = -1;
          

            for (int i = 0; i < sentence.Length; i++)
            {
                if (Char.IsLetter(sentence[i]) && !isWordStarted) // word started
                {
                    startIndexOfWord = i;
                    isWordStarted = true;
                    continue;
                }
                // "The greatest victory is that which requires no battle"
                if (!Char.IsLetter(sentence[i]) && isWordStarted || i + 1 == sentence.Length) // word has ended
                {
                    isWordStarted = false;

                    for (int j = result.Length - i - 1, d = startIndexOfWord; j < result.Length - startIndexOfWord; j++, d++)
                    {
                        result[j] = sentence[d];
                        
                    }
                    continue;
                }

            }

            return new string(result);
        }
    }
}
