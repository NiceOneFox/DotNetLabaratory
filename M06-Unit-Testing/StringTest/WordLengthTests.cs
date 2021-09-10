using NUnit.Framework;
using StringHelper;

namespace StringOverviewTests
{
    public class WordLengthTests //2
    {
        [TestCase("wee see lee", ExpectedResult = 2.66d)]
        [TestCase("Some information, has written;", ExpectedResult = 6.25d)]
        public double AverageWordLength_CorrectString(string input)
        {
            return WordLength.AverageWordLength(input);
        }
        [Test]
        public void AverageWordLength_OneWordString_1Expected()
        {
            string input = "do";
            Assert.AreEqual(2d, WordLength.AverageWordLength(input));
        }

        [Test]
        public void AverageWordLength_CorrectString_4Expected()
        {
            string input = "we also know as creators.";
            Assert.AreEqual(4d, WordLength.AverageWordLength(input));
        }

        [Test]
        public void AverageWordLength_EmptyString_0Expected()
        {
            Assert.AreEqual(0, WordLength.AverageWordLength(""));
        }

        [Test]
        public void AverageWordLength_NullString_0Expected()
        {
            string testString = null;

            Assert.AreEqual(0, WordLength.AverageWordLength(testString));
        }
    }
}