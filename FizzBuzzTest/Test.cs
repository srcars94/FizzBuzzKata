using FizzBuzzKata;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Does_Return_String()
        {
            var input = 1;

            var fizzBuzz = Program.GetValue(input);

            Assert.AreEqual("Hello", fizzBuzz);
        }
    }
}