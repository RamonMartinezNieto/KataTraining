/*
 * In list with 100 positions return a list wit the sequent rules: 
 * 
 * Return Fizz if the number is divisible by 3.
 * Return Buzz  if the number is divisible by 5.
 * Return FizzBuzz  if the number is divisible by 3 & 5.
 * Others numbers should be the same number of Index 
 */

using NUnit.Framework;

namespace TestFizzBuzz._5
{
    [TestFixture]
    class TestFizzBuzz
    {
        FizzBuzzFive fizzBuzz;
        string[] resultsArray; 

        [SetUp]
        public void SetUp() 
        {
            fizzBuzz = new FizzBuzzFive();
            resultsArray = fizzBuzz.GetResultsInArray();
        } 

        [Test]
        public void ArrayResultsShouldBeLength100()
        {    
            Assert.That(resultsArray.Length, Is.EqualTo(100));
        }

        [TestCase(2,ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Fizz")]
        [TestCase(8, ExpectedResult = "Fizz")]
        public string ShouldBeFizzWhenIsDivisibleBy3(int input) 
        {
            return resultsArray[input];   
        }

        [TestCase(4, ExpectedResult = "Buzz")]
        [TestCase(9, ExpectedResult = "Buzz")]
        public string ShouldBeBuzzWhenIsDivisibleBy5(int input)
        {
            return resultsArray[input];
        }

        [TestCase(14, ExpectedResult = "FizzBuzz")]
        [TestCase(29, ExpectedResult = "FizzBuzz")]
        [TestCase(44, ExpectedResult = "FizzBuzz")]
        public string ShouldBeFizzBuzzWhenIsDivisibleBy15(int input)
        {
            return resultsArray[input];
        }
        [TestCase(0, ExpectedResult = "1")]
        [TestCase(1, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "4")]
        public string ShouldBeTheSameNumberWhenIsNotDivisibleBy3or5or15(int input)
        {
            return resultsArray[input];
        }

    }
}
