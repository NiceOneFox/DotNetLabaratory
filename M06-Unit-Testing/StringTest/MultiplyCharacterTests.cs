using NUnit.Framework;
using StringHelper;

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

        [TestCase(null, "SomeText", ExpectedResult = "")]
        [TestCase("SomeText", null, ExpectedResult = "")]
        [TestCase(null, null, ExpectedResult = "")]
        public string DoubleCharacters_StringNull_ExpectedEmptyString(string first, string second)
        {
            return MultiplyCharater.DoubleCharacters(first, second);
        }

    }
}
