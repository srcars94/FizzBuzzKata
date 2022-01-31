using FizzBuzzKata;
using NUnit.Framework;
using System;

namespace FizzBuzzTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Does_Return_Input([Values(1, 2, 4, 7)] int input)
        {
            var output = Program.GetValue(input);

            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Returns_Fizz_When_Div_By_3([Values(3, 6, 9, 12)] int input)
        {
            var output = Program.GetValue(input);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Returns_Buzz_When_Div_By_5([Values(5, 10, 20, 40)] int input)
        {
            var output = Program.GetValue(input);

            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Returns_FizzBuzz_When_Div_3_and_5([Values(15, 30, 60, 90)] int input)
        {
            var output = Program.GetValue(input);

            Assert.AreEqual("FizzBuzz", output);
        }

        [Test]
        public void Throws_Null_Exceptions([Values(0)] int input)
        {
            Assert.Throws<ArgumentNullException>(() => Program.GetValue(input));
        }
    }
}