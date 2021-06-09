﻿using NUnit.Framework;

/*
 * - All years divisible by 400 ARE leap years (so, for example, 2000 was indeed a leap year),
 * - All years divisible by 100 but not by 400 are NOT leap years (so, for example, 1700, 1800, and 1900 were NOT leap years, NOR will 2100 be a leap year),
 * - All years divisible by 4 but not by 100 ARE leap years (e.g., 2008, 2012, 2016),
 * - All years not divisible by 4 are NOT leap years (e.g. 2017, 2018, 2019).
*/
namespace UnitTestKataLeapYear._4
{
    [TestFixture]
    class TestLeapYearIteration4
    {
        LeapYearIterationFour leapYear;
        
        [SetUp]
        public void SetUp() {
            leapYear = new LeapYearIterationFour();
        }

        [Test]
        public void ShouldBeFalse_WehnNotDisivibleByFour() {
            Assert.That(leapYear.IsLeap(1999), Is.False);
        }

        [Test]
        public void ShouldBeTrue_WehnIsDisivibleByFour()
        {
            Assert.That(leapYear.IsLeap(2020), Is.True);
        }

        [Test]
        public void ShouldBeFalse_WhenIsDivisibleBy100() {
            Assert.That(leapYear.IsLeap(2100), Is.False);
        }

        [Test]
        public void ShouldBeTrue_WhenIsDivisibleBy400()
        {
            Assert.That(leapYear.IsLeap(2000), Is.True);
        }
    }
}
