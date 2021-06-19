using NUnit.Framework;
using System;

/*
 * Roman Numbers Rules
 *  For example: 3 = III 
 *  But 4 is = IV  (five minus one) 
 *  
 * 
 * Roman Number Letters: 
 * I, V, X, L, C, D, M
 * 1,5,10,50, 100, 500, 1000 
 * 
 * Note: From 5000 to XX there is an special annotation adding underline up.
 * 
 * \u0305 => Add underline
 * 
 */
namespace TestRomanNumbers._2
{
    [TestFixture]
    class TestRomanNumbers2
    {
        RomanNumbers2 romanNumber;

        [SetUp]
        public void SetUp() {
            romanNumber = new RomanNumbers2();
        }

        [Test]
        public void ShouldBeIPassing1() {
            Assert.That(romanNumber.ConvertToRomanNumber(1), Is.EqualTo("I"));
        }

        [Test]
        public void ShouldBeIIPassing2()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(2), Is.EqualTo("II"));
        }

        [Test]
        public void ShouldBeIIIPassing3()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(3), Is.EqualTo("III"));
        }


        [Test]
        public void ShouldBeIVPassing4()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(4), Is.EqualTo("IV"));
        }


        [Test]
        public void ShouldBeVPassing5()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(5), Is.EqualTo("V"));
        }


        [Test]
        public void ShouldBeVIPassing6()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(6), Is.EqualTo("VI"));
        }

        [Test]
        public void ShouldBeVIIPassing7()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(7), Is.EqualTo("VII"));
        }

        [Test]
        public void ShouldBeVIIIPassing8()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(8), Is.EqualTo("VIII"));
        }


        [Test]
        public void ShouldBeIXPassing9()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(9), Is.EqualTo("IX"));
        }

        [TestCase(10, ExpectedResult = "X")]
        [TestCase(11, ExpectedResult = "XI")]
        [TestCase(13, ExpectedResult = "XIII")]
        [TestCase(14, ExpectedResult = "XIV")]
        [TestCase(18, ExpectedResult = "XVIII")]
        [TestCase(19, ExpectedResult = "XIX")]
        [TestCase(20, ExpectedResult = "XX")]
        public string TestCaseOfDifferentRomanNumberBetweenXandXX(int input)
        {
            return romanNumber.ConvertToRomanNumber(input);
        }

        [Test]
        public void ShouldBeXXIXWhenPass29()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(29), Is.EqualTo("XXIX"));
        }

        [Test]
        public void ShouldBeXLWhenPass40()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(40), Is.EqualTo("XL"));
        }

        [TestCase(41,ExpectedResult = "XLI")]
        [TestCase(42, ExpectedResult = "XLII")]
        [TestCase(43, ExpectedResult = "XLIII")]
        [TestCase(44, ExpectedResult = "XLIV")]
        [TestCase(45, ExpectedResult = "XLV")]
        [TestCase(46, ExpectedResult = "XLVI")]
        [TestCase(47, ExpectedResult = "XLVII")]
        [TestCase(48, ExpectedResult = "XLVIII")]
        [TestCase(49, ExpectedResult = "XLIX")]
        public string TestCaseOfDifferentRomanNumberBetween40and48(int input)
        {
            return romanNumber.ConvertToRomanNumber(input);
        }

        [Test]
        public void ShouldBeLWhenPass50() {
            Assert.That(romanNumber.ConvertToRomanNumber(50), Is.EqualTo("L"));
        }

        [Test]
        public void ShouldBeLXXXVIIIWhenPass88()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(88), Is.EqualTo("LXXXVIII"));
        }


        [Test]
        public void ShouldBeXCWhenPass90()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(90), Is.EqualTo("XC"));
        }

        [Test]
        public void ShouldBeCDWhenPass400()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(400), Is.EqualTo("CD"));
        }

        [Test]
        public void ShouldBeDWhenPass500()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(500), Is.EqualTo("D"));
        }


        [Test]
        public void ShouldBeCMWhenPass900()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(900), Is.EqualTo("CM"));
        }

        [Test]
        public void ShouldBeMWhenPass1000()
        {
            Assert.That(romanNumber.ConvertToRomanNumber(1000), Is.EqualTo("M"));
        }

        [TestCase(2343, ExpectedResult = "MMCCCXLIII")]
        [TestCase(3444, ExpectedResult = "MMMCDXLIV")]
        [TestCase(1232, ExpectedResult = "MCCXXXII")]
        [TestCase(787, ExpectedResult = "DCCLXXXVII")]
        public string TestRandomNumbers(int input)
        {
            return romanNumber.ConvertToRomanNumber(input);
        }

        [Test]
        public void ShouldThrowExceptionWhenIs0orMinus()
        {
            var ex = Assert.Throws<Exception>(() => romanNumber.ConvertToRomanNumber(0));
            Assert.That(ex.Message, Is.EqualTo("Invalid number"));
          
        }

    }
}
