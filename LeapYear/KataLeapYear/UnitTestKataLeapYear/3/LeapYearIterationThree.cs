using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * No divisible by 4 is not leap 
 * Divisible by 4 is leap
 * Divisible by 100 is not leap
 * Divisible by 400 is leap.
 * 
 *  [TestCase(2021, ExpectedResult = false)]
 *  [TestCase(2020, ExpectedResult = true)]
 *  [TestCase(34, ExpectedResult = false)]
 */

namespace UnitTestKataLeapYear._3
{



    [TestFixture]
    class LeapYearIterationThree
    {
        LeapYearThree leapYearThree;

        [SetUp]
        public void InitSetUpt() {
            leapYearThree = new LeapYearThree();
        }

        [Test]
        public void GivenDisvisibleBy4_CheckIf_IsLeap_True()
        {
            Assert.That(leapYearThree.IsLeapYear(2020), Is.EqualTo(true));
        }

        [Test]
        public void GivenNumberNotDisivibleBy4_CheckIf_IsLeap_False()
        {
            Assert.That(leapYearThree.IsLeapYear(1999), Is.EqualTo(false));
        }

        [Test]
        public void GivenNumberDivisibleBy100_CheckIfIsLeap_false() {
            Assert.That(leapYearThree.IsLeapYear(2100), Is.EqualTo(false));
        }

        [Test]
        public void GivenNumberDivisibleBy400_CheckIfIsLeap_false() {
            Assert.That(leapYearThree.IsLeapYear(2000), Is.EqualTo(true));
        }
    }
}
