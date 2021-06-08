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
        public void CallingGetArrayWithResult_CheckArrayWith100Positions() {
            Assert.That(arrayResults.Length, Is.EqualTo(100));
        }

        [Test]
        public void GettingArrayWithResults_CheckIfPosition3_IsFizz()
        {
            Assert.That(arrayResults[2], Is.EqualTo("Fizz"));
        }

        [Test]
        public void GettingArrayWithResults_CheckIfPosition5_IsBuzz()
        {
            Assert.That(arrayResults[4], Is.EqualTo("Buzz"));
        }

        [Test]
        public void GettingArrayWithResults_CheckIfPosition15_IsFizzBuzz()
        {
            Assert.That(arrayResults[14], Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GettingArrayWithResults_CheckIfPositionNotDivisibleBy3or5or15_isCorrectNumber() 
        {
            Assert.That(arrayResults[0], Is.EqualTo("1"));
        }

        [Test]
        public void IfNUmberIsDivisibleBy3thenIsFizz([Range(0,99)] int number) {
            if ((number + 1) % 15 == 0)
            {
                Assert.That(arrayResults[number], Is.EqualTo("FizzBuzz"));
            }
            else if ((number + 1) % 3 == 0)
            {
                Assert.That(arrayResults[number], Is.EqualTo("Fizz"));
            }
            else if ((number + 1) % 5 == 0)
            {
                Assert.That(arrayResults[number], Is.EqualTo("Buzz"));
            }
            else {
                Assert.That(arrayResults[number], Is.EqualTo((number + 1).ToString()));
            }
        }

    }
}
