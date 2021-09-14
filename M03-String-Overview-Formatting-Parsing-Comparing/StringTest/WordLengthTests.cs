using NUnit.Framework;
using StringHelper;
using StringHelperTests.DataCaseTests;

namespace StringOverviewTests
{
    public class WordLengthTests //2
    {
        [TestCase("wee see lee", 2.66)]
        [TestCase("Some information, has written;", 6.25)]
        public void AverageWordLength_CorrectString(string input, double expectedResult)
        {
            double result = WordLength.AverageWordLength(input);

            Assert.AreEqual(expectedResult, Is.EqualTo(result).Within(1).Ulps);
        }

        [TestCaseSource(typeof(StringTestCaseSource), nameof(StringTestCaseSource.NullOrEmptyStringCase0DoubleExpected))]
        public void AverageWordLength_EmptyString_0Expected(string input, double expectedResult)
        {
            double result = -1d;

            result = WordLength.AverageWordLength(input);

            Assert.AreEqual(expectedResult, result);
        }
    }
}