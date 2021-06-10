using NUnit.Framework;

/*
- Return Fizz if the number is divisible by 3.
- Return Buzz  if the number is divisible by 5.
- Return FizzBuzz  if the number is divisible by 3 & 5.
*/
namespace TestFizzBuzz.IterationFour
{
    [TestFixture]
    class TestFizzBuzz
    {
        FizzBuzzIterationFour fizzBuzz;
        string[] results;

        [SetUp]
        public void SetUp() {
            fizzBuzz = new FizzBuzzIterationFour();
            results = fizzBuzz.GetResults();
        }

        [Test]
        public void ArrayShoulBe100positions() {
            Assert.That(results.Length, Is.EqualTo(100));
        }

        [TestCase(2, ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Fizz")]
        [TestCase(8, ExpectedResult = "Fizz")]
        public string ShouldBeFizzWhenDisivisbleBy3(int testCase) {
            return results[testCase];
        }

        [TestCase(4, ExpectedResult = "Buzz")]
        [TestCase(9, ExpectedResult = "Buzz")]
        public string ShouldBeBuzzWhenDisivisbleBy5(int testCase)
        {
            return results[testCase];
        }

        [TestCase(14, ExpectedResult = "FizzBuzz")]
        [TestCase(29, ExpectedResult = "FizzBuzz")]
        public string ShouldBeFizzBuzzWhenDivisibleBy15(int testCase) {
            return results[testCase];
        }

        [TestCase(0, ExpectedResult = "1")]
        [TestCase(1, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "4")]
        public string ShouldBeTheSameNumberWhenOtherCases(int testCase) {
            return results[testCase];
        }

        [Test]
        public void ShouldBeFizzBuzz50WhenIsDivisibleBy50()
        {
            Assert.That(results[49], Is.EqualTo("FizzBuzz50"));
        }
    }
}
