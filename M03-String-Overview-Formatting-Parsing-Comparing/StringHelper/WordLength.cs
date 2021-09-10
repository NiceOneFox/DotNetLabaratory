using System;

namespace StringHelper
{
    public static class WordLength
    {
        /// <param name="input">Input string which contains words</param>
        /// <returns>Average length of words in string</returns>
        public static double AverageWordLength(string input)
        {
            if (input?.Length == 0 || input is null)
            {
                return 0;
            }

            double lengthOfWordsInSentence = 0d;

            int startIndexOfWord = -1;

            bool isWordStarted = false;

            int numberOfWordsInSentence = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]) && !isWordStarted) // word started
                {
                    startIndexOfWord = i;
                    isWordStarted = true;
                    continue;
                }

                if (!Char.IsLetter(input[i]) && isWordStarted || i == input.Length - 1) // word has ended
                {
                    isWordStarted = false;
                    numberOfWordsInSentence++;
                    lengthOfWordsInSentence += i - startIndexOfWord;
                    continue;
                }

            }       

            return lengthOfWordsInSentence / numberOfWordsInSentence;
        }
    }
}
