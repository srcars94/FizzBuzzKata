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

            var output = Program.GetValue(input);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Returns_Buzz_When_5()
        {
            var input = 5;

            var output = Program.GetValue(input);

            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Returns_FizzBuzz_When_15()
        {
            var input = 15;

            var output = Program.GetValue(input);

            Assert.AreEqual("FizzBuzz", output);
        }
    }
}