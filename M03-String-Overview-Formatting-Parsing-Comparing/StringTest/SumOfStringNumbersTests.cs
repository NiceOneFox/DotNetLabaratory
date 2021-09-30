using NUnit.Framework;
using StringHelper;
using StringHelperTests.DataCaseTests;

namespace StringOverviewTests //4
{
    public class SumOfStringNumbersTests
    {
        [TestCase("456789032", "6000000004", ExpectedResult = "6456789036")]
        [TestCase("834", "31", ExpectedResult = "865")]
        public string SumOfTwoLongNumbers_CorrectInput(string first, string second)
        {
            return SumOfStringNumbers.SumOfTwoLongNumbers(first, second);
        }

        [TestCaseSource(typeof(StringTestCaseSource), nameof(StringTestCaseSource.NullCases0StringExpected))]
        public void DoubleCharacters_StringNull_0Expected(string first, string second, string expectedResult)
        {
            string result = "value"; // not empty string as we expect empty one

            result = SumOfStringNumbers.SumOfTwoLongNumbers(first, second);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("47906", "", ExpectedResult = "47906")]
        public string DoubleCharacters_FirstStringEmpty_SecondStringExpected(string first, string second)
        {
            return SumOfStringNumbers.SumOfTwoLongNumbers(first, second);
        }

        [TestCase("", "90003", ExpectedResult = "90003")]
        public string DoubleCharacters_SecondStringEmpty_FirstStringExpected(string first, string second)
        {
            return SumOfStringNumbers.SumOfTwoLongNumbers(first, second);
        }
    }
}
