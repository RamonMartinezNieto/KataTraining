using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * - All years divisible by 400 ARE leap years (so, for example, 2000 was indeed a leap year),
 * - All years divisible by 100 but not by 400 are NOT leap years (so, for example, 1700, 1800, and 1900 were NOT leap years, NOR will 2100 be a leap year),
 * - All years divisible by 4 but not by 100 ARE leap years (e.g., 2008, 2012, 2016),
 * - All years not divisible by 4 are NOT leap years (e.g. 2017, 2018, 2019).
*/
namespace UnitTestKataLeapYear._5
{
    [TestFixture]
    class TestLeapYearFive
    {
        LeapYearFive leapYear;

        [SetUp]
        public void SetUp() {
            leapYear = new LeapYearFive();
        }

        [Test]
        public void ShouldBeTrueIfDivisibleByFour() { 
            Assert.That(leapYear.IsLeap(1980), Is.EqualTo(true));
        }

        [Test]
        public void ShouldBeFalseIfNotDivisibleByFour()
        {
            Assert.That(leapYear.IsLeap(2019), Is.EqualTo(false));
        }

        [Test]
        public void ShouldBeTrueIfIsDivisibleBy400()
        {
            Assert.That(leapYear.IsLeap(2000), Is.EqualTo(true));
        }

        [Test]
        public void ShouldBeFalseIfIsDivisibleBy100()
        {
            Assert.That(leapYear.IsLeap(2100), Is.EqualTo(false));
        }


        [TestCase(1980, ExpectedResult = true)]
        [TestCase(2019, ExpectedResult = false)]
        [TestCase(2000, ExpectedResult = true)]
        [TestCase(2100, ExpectedResult = false)]
        public bool TestAllCases(int testCase) {
            return leapYear.IsLeap(testCase);
        }
    }
}
