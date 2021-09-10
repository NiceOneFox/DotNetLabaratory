using NUnit.Framework;
using StringHelper;

namespace StringOverviewTests
{
    public class WordReverseTests //5
    {
        [TestCase("9004", ExpectedResult = "4009")]
        [TestCase("Typical string with comma.", ExpectedResult = "comma with string Typical")]
        public string Reverse_CorrectInput(string sentence)
        {
            return WordReverse.Reverse(sentence);
        }

        [TestCaseSource(nameof(EmptyNullCases))]
        public void Reverse_NullString_EmptyStringExpected(string sentence)
        {
            string result = WordReverse.Reverse(sentence);
            Assert.AreEqual("", result);
        }

        static object[] EmptyNullCases =
        {
        new object[] { null},
        new object[] { "" },
        };

    }
}
