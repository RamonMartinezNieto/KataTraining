using NUnit.Framework;

/*
 * - All years divisible by 400 ARE leap years (so, for example, 2000 was indeed a leap year),
 * - All years divisible by 100 but not by 400 are NOT leap years (so, for example, 1700, 1800, and 1900 were NOT leap years, NOR will 2100 be a leap year),
 * - All years divisible by 4 but not by 100 ARE leap years (e.g., 2008, 2012, 2016),
 * - All years not divisible by 4 are NOT leap years (e.g. 2017, 2018, 2019).
*/

namespace UnitTestKataLeapYear._6
{
    [TestFixture]
    class TestKataLeapYear
    {
        LeapYearSix leapYear; 

        [SetUp]
        public void SetUp() 
        {
            leapYear = new LeapYearSix();
        }

        [Test]
        public void ShouldBeTrueYearsDivisibleBy400()
        {
            Assert.That(leapYear.IsLeap(2000), Is.EqualTo(true));
        }

        [Test]
        public void ShouldBeFalseYearsDivisibleBy100AndNotDivisibleBy100()
        {
            Assert.That(leapYear.IsLeap(1900), Is.EqualTo(false));
        }

        [Test]
        public void ShouldBeTrueYearsDivisibleBy4AndNotDivisibleBy100()
        {
            Assert.That(leapYear.IsLeap(2008), Is.EqualTo(true));
        }

        [Test]
        public void ShouldBeFalseYearsNotDivisibleBy4()
        {
            Assert.That(leapYear.IsLeap(2017), Is.EqualTo(false));
        }
    }
}
