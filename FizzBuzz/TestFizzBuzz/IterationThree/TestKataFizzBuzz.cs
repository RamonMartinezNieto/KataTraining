using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestFizzBuzz.IterationThree
{
    [TestFixture]
    class TestKataFizzBuzz
    {
        FizzBuzzIterationThree fizzBuzz;
        string[] results;

        [SetUp]
        public void SetUp() {
            fizzBuzz = new FizzBuzzIterationThree();
            results = fizzBuzz.GetResultsFizzBuzz();
        }

        [Test]
        public void ArrayShoulBe100Length() {
            Assert.That(results.Length, Is.EqualTo(100));        
        }

        [Test]
        public void ShouldBeFizzWhenIsDivisibleBy3([Range(2, 8, 3)] int testCase) 
        {
            Assert.That(results[testCase], Is.EqualTo("Fizz"));
        }

        [Test]
        public void ShouldBeBuzzWhenIsDivisibleBy5([Range(4, 9, 5)] int testCase)
        {
            Assert.That(results[testCase], Is.EqualTo("Buzz"));
        }


        [Test]
        public void ShouldBeFizzBuzzWhenIsDivisibleBy15([Range(14, 100, 15)] int testCase)
        {
            Assert.That(results[testCase], Is.EqualTo("FizzBuzz"));
        }

        [TestCase(0, ExpectedResult = "1")]
        [TestCase(1, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "4")]
        [TestCase(6, ExpectedResult = "7")]
        public string ShouldBeItselfNumberWhenOtherCases(int testCase) {
            return results[testCase];
        }
    }


}
