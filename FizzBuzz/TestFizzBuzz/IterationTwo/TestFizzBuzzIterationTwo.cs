using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestFizzBuzz.IterationTwo
{
    [TestFixture]
    class TestFizzBuzzIterationTwo
    {
        FizzBuzzIterationTwo fizzBuzz;
        string[] arrayResults;

        [SetUp]
        public void SetUp()
        {
            fizzBuzz = new FizzBuzzIterationTwo();
            arrayResults = fizzBuzz.GetArrayWithResults();
        }

        [Test]
        public void FizzBuzzArrayLegth100() {
            Assert.That(arrayResults.Length, Is.EqualTo(100));
        }

        [Test]
        public void FizzBuzzCheckThatAllNumbersInTheArrayHaveTheCorrectData([Range(0,99)] int number) {
            if ((number + 1) % 15 == 0)
                Assert.That(arrayResults[number], Is.EqualTo("FizzBuzz"));
            else if ((number + 1) % 3 == 0)
                Assert.That(arrayResults[number], Is.EqualTo("Fizz"));
            else if ((number + 1) % 5 == 0)
                Assert.That(arrayResults[number], Is.EqualTo("Buzz"));
            else 
                Assert.That(arrayResults[number], Is.EqualTo((number + 1).ToString()));
        }
    }
}
