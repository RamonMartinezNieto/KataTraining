using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestKataLeapYear._2
{
    /*
     * NO Divisible por 4 no bisiesto
     * Divisible por 4 bisiesto
     * Divisible por 100 NO bisiesto 
     * Divisible por 400 bisiesto.
     * 
     * 
        [TestCase(2021, ExpectedResult = false)]
        [TestCase(2020, ExpectedResult = true)]
        [TestCase(34, ExpectedResult = false)]
     */
    [TestFixture]
    public class TestLeapYearDos
    {
        LeapYearDos leapYear;

        [SetUp]
        public void InitSetUp() {
            leapYear = new LeapYearDos(); 
        }

        [Test]
        public void Test_Check_Method_IsLeap() {
            bool isLeap = leapYear.IsLeap(1980); 
        }

        [Test]
        public void Test_Check_Is_Leap_When_True() {
            Assert.That(leapYear.IsLeap(2020), Is.EqualTo(true)); 
        }

        [Test]
        public void Test_Check_Is_Leap_When_False()
        {
            Assert.That(leapYear.IsLeap(2021), Is.EqualTo(false));
        }


        [Test]
        public void Test_Check_Is_Leap_When_Divisible_By_100()
        {
            Assert.That(leapYear.IsLeap(1800), Is.EqualTo(false));
        }


        [Test]
        public void Test_Check_Is_Leap_When_Divisible_By_400()
        {
            Assert.That(leapYear.IsLeap(400), Is.EqualTo(true));
        }

        [Test]
        public void Test_Check_Is_Leap_When_Number_Is_Negative_Throw_Exception() {
            
            NegativeYearException exception = 
                Assert.Throws<NegativeYearException>( () => leapYear.IsLeap(-100));
            
            Assert.That(exception.Message, Is.EqualTo("Year can't be negative."));
        }
    }
}
