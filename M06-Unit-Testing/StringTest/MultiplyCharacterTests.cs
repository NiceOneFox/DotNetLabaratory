using NUnit.Framework;
using StringHelper;
using StringHelperTests.DataCaseTests;

namespace StringOverviewTests
{
    public class MultiplyCharacterTests //3
    {
        [TestCase("Hello", "World", ExpectedResult = "Helllloo")]
        [TestCase("T-34", "593674", ExpectedResult = "T-3344")]
        public string DoubleCharacters_CorrectInput(string first, string second)
        {
            return MultiplyCharater.DoubleCharacters(first, second);
        }

        [TestCaseSource(typeof(StringTestCaseSource), nameof(StringTestCaseSource.NullCasesEmptyStringExpected))]
        public void DoubleCharacters_StringNull_ExpectedEmptyString(string first, string second, string expectedResult)
        {
            string result = "value"; // not empty string as we expect empty one

            result = MultiplyCharater.DoubleCharacters(first, second);

            Assert.AreEqual(expectedResult, result);
        }

    }
}
