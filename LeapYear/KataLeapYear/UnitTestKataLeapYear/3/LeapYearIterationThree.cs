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

        [TestCase(1999, ExpectedResult = false)]
        [TestCase(2020, ExpectedResult = true)]
        [TestCase(2100, ExpectedResult = false)]
        [TestCase(2000, ExpectedResult = true)]
        public bool GivenDisvisibleBy4_CheckIf_IsLeap_True(int year)
        {
            return leapYearThree.IsLeapYear(year);
        }

    }
}
