using FizzBuzzKata;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Does_Return_String_Number_1()
        {
            var input = 1;

            var output = Program.GetValue(input);

            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Does_Return_String_Number_2()
        {
            var input = 2;

            var output = Program.GetValue(input);

            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Returns_Fizz_When_3()
        {
            var input = 3;

            var output = Program.GetValue(3);

            Assert.AreEqual("Fizz", output);
        }
    }
}