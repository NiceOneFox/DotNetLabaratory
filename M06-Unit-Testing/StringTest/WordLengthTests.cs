using NUnit.Framework;

namespace StringOverviewTests
{
    public class WordLengthTests //2
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AverageWordLength_EmptyString_0Expected(string input)
        {
            Assert.Pass();
        }
    }
}