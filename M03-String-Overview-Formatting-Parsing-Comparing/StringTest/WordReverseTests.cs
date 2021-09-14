using NUnit.Framework;
using StringHelper;
using StringHelperTests.DataCaseTests;

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

        [TestCaseSource(typeof(StringTestCaseSource), nameof(StringTestCaseSource.NullOrEmptyStringCaseEmptyStringExpected))]
        public void Reverse_NullOrEmptyString_EmptyStringExpected(string sentence, string expectedResult)
        {
            string result = "result";
                
            result = WordReverse.Reverse(sentence);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
