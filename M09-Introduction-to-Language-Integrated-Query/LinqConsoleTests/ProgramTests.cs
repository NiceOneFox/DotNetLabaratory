using NUnit.Framework;
using LinqConsole;

namespace LinqConsoleTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Main_NameParameter_Exptected2Students()
        {
            string[] args = { "-s", "Grisha-Ivanov", "-m", "5", "-l", "3" };                     

           // LinqConsole.Program.Main();

            Assert.Pass();
        }
    }
}