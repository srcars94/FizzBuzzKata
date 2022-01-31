using FizzBuzzKata;
using NUnit.Framework;

namespace FizzBuzzTest
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Does_Return_String()
        {
            var fizzBuzz = Program.FizzBuzz();

            Assert.AreEqual("Hello", fizzBuzz);
        }
    }
}