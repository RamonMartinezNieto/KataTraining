using NUnit.Framework;

namespace UnitTestKataLeapYear
{
    [TestFixture]
    public class TestLeapYearChecker
    {
        public LeapYearChecker leapYearChecker;

        [SetUp]
        public void TestYearIsLeapTrue() {
            leapYearChecker = new LeapYearChecker();
        }

        [TestCase(2021, ExpectedResult = false)]
        [TestCase(2020, ExpectedResult = true)]
        [TestCase(34, ExpectedResult = false)]
        public bool TestYearIsLeap(int year)
        {
            return leapYearChecker.IsLeap(year);
        }

        [Test]
        public void TestYearIsLeapRangeParametersOther([Range(1,4000,4)] int yearRange)
        {
            Assert.AreEqual(false, leapYearChecker.IsLeap(yearRange));
        }

        [Test]
        public void TestYearInitWithNegativeNumbersThrowExceptionMessage()
        {
            YearExceptionNotNegativePossible yearException =
                Assert.Throws<YearExceptionNotNegativePossible>(
                    () => { leapYearChecker.IsLeap(-100); }
                );
            Assert.AreEqual("Year not valid, is not allowed negative years", yearException.Message);
        }
    }
}