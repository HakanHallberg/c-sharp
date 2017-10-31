using System;
using NUnit.Framework;
using FizzBuzzLib;

namespace FizzBuzzLibTest
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_When_Default_Returns_Input([Values(1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19)] int input)
        {        
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_When_Div3_Returns_Fizz([Values(3, 6, 9, 12, 18)] int input)
        {
            
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_WhenDiv5_Returns_Buzz([Values(5, 10, 20)] int input)
        {
            
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_WhenDiv3_AndDiv5_Returns_FizzBuzz([Values(15)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
