using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Roman Numbers Rules
 *  For example: 3 = III 
 *  But 4 is = IV  (five minus one) 
 *  
 * Roman Number Letters: 
 * I, V, X, L, C, D, M
 * 1, 5, 10, 50, 100, 500, 1000 
 * 
 * Note: From 4000 to XX there is an special annotation adding underline up.
 * \u0305 => Add underline
 */
namespace TestRomanNumbers._4
{
    [TestFixture]
    class TestKataRomanNumerals
    {
        RomanNumeralsFour romanNumerals;
        
        [SetUp]
        public void SetUp() {
            romanNumerals = new RomanNumeralsFour();
        }

        [TestCase(1, ExpectedResult = "I")]
        [TestCase(2, ExpectedResult = "II")]
        [TestCase(3, ExpectedResult = "III")]
        public string ShouldConvertTheAlgebraicNumerToRomanNumberFirstRomanNumber(int number) 
        {
            return romanNumerals.GetRomanNumer(number);
        }

        [TestCase(4, ExpectedResult = "IV")]
        [TestCase(5, ExpectedResult = "V")]
        [TestCase(6, ExpectedResult = "VI")]
        [TestCase(7, ExpectedResult = "VII")]
        public string ShouldConvertTheAlgebraicNumerToRomanNumberSecondRomanNumber(int number)
        {
            return romanNumerals.GetRomanNumer(number);
        }

        [TestCase(9, ExpectedResult = "IX")]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(11, ExpectedResult = "XI")]
        [TestCase(12, ExpectedResult = "XII")]
        [TestCase(13, ExpectedResult = "XIII")]
        [TestCase(14, ExpectedResult = "XIV")]
        [TestCase(15, ExpectedResult = "XV")]
        [TestCase(29, ExpectedResult = "XXIX")]
        public string ShouldConvertTheAlgebraicNumerToRomanNumberThirdRomanNumber(int number)
        {
            return romanNumerals.GetRomanNumer(number);
        }

        [TestCase(40, ExpectedResult = "XL")]
        [TestCase(50, ExpectedResult = "L")]
        public string ShouldConvertTheAlgebraicNumerToRomanNumberFourthRomanNumber(int number)
        {
            return romanNumerals.GetRomanNumer(number);
        }


        [Test]
        public void ShouldBeXCWhenPass90()
        {
            Assert.That(romanNumerals.GetRomanNumer(90), Is.EqualTo("XC"));
        }
        [Test]
        public void ShouldBeCWhenPass100()
        {
            Assert.That(romanNumerals.GetRomanNumer(100), Is.EqualTo("C"));
        }

        [Test]
        public void ShouldBeCDWhenPass400()
        {
            Assert.That(romanNumerals.GetRomanNumer(400), Is.EqualTo("CD"));
        }
        [Test]
        public void ShouldBeDWhenPass500()
        {
            Assert.That(romanNumerals.GetRomanNumer(500), Is.EqualTo("D"));
        }
        [Test]
        public void ShouldBeCMWhenPass900()
        {
            Assert.That(romanNumerals.GetRomanNumer(900), Is.EqualTo("CM"));
        }
        [Test]
        public void ShouldBeMWhenPass1000()
        {
            Assert.That(romanNumerals.GetRomanNumer(1000), Is.EqualTo("M"));
        }

        [TestCase(1234, ExpectedResult = "MCCXXXIV")]
        [TestCase(2345, ExpectedResult = "MMCCCXLV")]
        [TestCase(3476, ExpectedResult = "MMMCDLXXVI")]
        public string RandomTests(int input)
        {
            return romanNumerals.GetRomanNumer(input);
        }


    }
}
