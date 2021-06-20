/*
 * - All years divisible by 400 ARE leap years (so, for example, 2000 was indeed a leap year),
 * - All years divisible by 100 but not by 400 are NOT leap years (so, for example, 1700, 1800, and 1900 were NOT leap years, NOR will 2100 be a leap year),
 * - All years divisible by 4 but not by 100 ARE leap years (e.g., 2008, 2012, 2016),
 * - All years not divisible by 4 are NOT leap years (e.g. 2017, 2018, 2019).
*/
using NUnit.Framework;

namespace UnitTestKataLeapYear._7
{
    [TestFixture]
    class TestKataLeapYear
    {
        LeapYearSeven leapYear; 

        [SetUp]
        public void SetUp() 
        {
            leapYear = new LeapYearSeven(); 
        }

        [Test]
        public void ShouldBeTrueIfIsDivisibleBy400()
        {
            Assert.That(leapYear.IsLeap(2000), Is.EqualTo(true));
        }

        [Test]
        public void ShouldBeFalseIfIsDivisibleBy100AndNotBy400()
        {
            Assert.That(leapYear.IsLeap(1900), Is.EqualTo(false));
        }

        [Test]
        public void ShouldBeTrueIfIsDivisibleBy4AndNotBy100()
        {
            Assert.That(leapYear.IsLeap(2008), Is.EqualTo(true));
        }

        [Test]
        public void ShouldBeFalseIfIsDivisibleBy4()
        {
            Assert.That(leapYear.IsLeap(2017), Is.EqualTo(false));
        }
    }
}
