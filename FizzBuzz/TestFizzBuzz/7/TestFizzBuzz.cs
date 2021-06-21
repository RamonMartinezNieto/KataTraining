
/*
 * In list with 100 positions return a list wit the sequent rules: 
 * 
 * Return Fizz if the number is divisible by 3.
 * Return Buzz  if the number is divisible by 5.
 * Return FizzBuzz  if the number is divisible by 3 & 5.
 * Others numbers should be the same number of Index 
 */
using NUnit.Framework;

namespace TestFizzBuzz._7
{
    [TestFixture]
    class TestFizzBuzz
    {
        FizzBuzzSeven fizzBuzz;
        string[] results;

        [SetUp]
        public void SetUp() 
        {
            fizzBuzz = new FizzBuzzSeven();
            results = fizzBuzz.GetResults();
        }

        [Test]
        public void ResultsArrayShouldHas100Positions() 
        {
            Assert.That(results.Length, Is.EqualTo(100));
        }

        [TestCase (2,ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Fizz")]
        [TestCase(8, ExpectedResult = "Fizz")]
        public string ShouldBeFizzWhenIsDivisibleBy3(int input) 
        {
            return results[input];
        }

        [TestCase(4, ExpectedResult = "Buzz")]
        [TestCase(9, ExpectedResult = "Buzz")]
        public string ShouldBeBuzzWhenIsDivisibleBy5(int input)
        {
            return results[input];
        }

        [TestCase(14, ExpectedResult = "FizzBuzz")]
        [TestCase(29, ExpectedResult = "FizzBuzz")]
        public string ShouldBeFizzBuzzWhenIsDivisibleBy15(int input)
        {
            return results[input];
        }

        [TestCase(0, ExpectedResult = "1")]
        [TestCase(1, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "4")]
        public string OtherNumbersShouldBeTheSameNumberAsItselfIndex(int input) 
        {
            return results[input];
        }
    }
}
