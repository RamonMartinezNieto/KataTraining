
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
using NUnit.Framework;

namespace TestRomanNumbers._3
{
    [TestFixture]
    class TestKataRomanNumerals
    {
        RomanNumeralsThree romanNumbers;

        [SetUp]
        public void SetUp() 
        {
            romanNumbers = new RomanNumeralsThree();
        }

        [Test]
        public void ShouldBeIWhenPass1() 
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(1), Is.EqualTo("I"));
        }
        [Test]
        public void ShouldBeIIWhenPass2()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(2), Is.EqualTo("II"));
        }
        [Test]
        public void ShouldBeIIIWhenPass3()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(3), Is.EqualTo("III"));
        }
        [Test]
        public void ShouldBeIVWhenPass4()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(4), Is.EqualTo("IV"));
        }
        [Test]
        public void ShouldBeVWhenPass5()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(5), Is.EqualTo("V"));
        }
        [Test]
        public void ShouldBeVIWhenPass6()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(6), Is.EqualTo("VI"));
        }
        [Test]
        public void ShouldBeIXWhenPass9()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(9), Is.EqualTo("IX"));
        }
        [Test]
        public void ShouldBeXWhenPass10()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(10), Is.EqualTo("X"));
        }
        [Test]
        public void ShouldBeXIWhenPass11()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(11), Is.EqualTo("XI"));
        }
        [Test]
        public void ShouldBeXXXIXWhenPass39()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(39), Is.EqualTo("XXXIX"));
        }

        [Test]
        public void ShouldBeXLWhenPass40()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(40), Is.EqualTo("XL"));
        }

        [Test]
        public void ShouldBeLWhenPass50()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(50), Is.EqualTo("L"));
        }

        [Test]
        public void ShouldBeXCWhenPass90()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(90), Is.EqualTo("XC"));
        }
        [Test]
        public void ShouldBeCWhenPass100()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(100), Is.EqualTo("C"));
        }

        [Test]
        public void ShouldBeCDWhenPass400()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(400), Is.EqualTo("CD"));
        }
        [Test]
        public void ShouldBeDWhenPass500()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(500), Is.EqualTo("D"));
        }
        [Test]
        public void ShouldBeCMWhenPass900()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(900), Is.EqualTo("CM"));
        }
        [Test]
        public void ShouldBeMWhenPass1000()
        {
            Assert.That(romanNumbers.ConvertToRomanNumber(1000), Is.EqualTo("M"));
        }

        [TestCase (1234, ExpectedResult = "MCCXXXIV")]
        [TestCase(2345, ExpectedResult = "MMCCCXLV")]
        [TestCase(3476, ExpectedResult = "MMMCDLXXVI")]
        public string RandomTests(int input)
        {
            return romanNumbers.ConvertToRomanNumber(input);
        }

    }
}
