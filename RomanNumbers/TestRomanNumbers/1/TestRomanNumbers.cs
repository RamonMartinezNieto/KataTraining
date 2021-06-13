using NUnit.Framework;

namespace TestRomanNumbers._1
{
    [TestFixture]
    class TestRomanNumbers
    {
        RomanNumbers romanNumbers;

        [SetUp]
        public void SetUp() 
        {
            romanNumbers = new RomanNumbers();
        }

        [Test]
        public void ShouldConvertNumbersToRoman() 
        {
            assertConvertsToRoman(1, "I");
            assertConvertsToRoman(2, "II"); 
            assertConvertsToRoman(3, "III");
            assertConvertsToRoman(4, "IV");
            assertConvertsToRoman(5, "V");
            assertConvertsToRoman(6, "VI");
            assertConvertsToRoman(7, "VII");
            assertConvertsToRoman(8, "VIII");
            assertConvertsToRoman(9, "IX");
            assertConvertsToRoman(10, "X");
            assertConvertsToRoman(11, "XI");
            assertConvertsToRoman(12, "XII");
            assertConvertsToRoman(13, "XIII");
            assertConvertsToRoman(14, "XIV");
            assertConvertsToRoman(15, "XV");
            assertConvertsToRoman(16, "XVI");
            assertConvertsToRoman(17, "XVII");
            assertConvertsToRoman(18, "XVIII");
            assertConvertsToRoman(19, "XIX");
            assertConvertsToRoman(20, "XX");
            assertConvertsToRoman(25, "XXV");
            assertConvertsToRoman(30, "XXX");
            assertConvertsToRoman(35, "XXXV");
            assertConvertsToRoman(39, "XXXIX");
            assertConvertsToRoman(40, "XL");
            assertConvertsToRoman(50, "L");
            assertConvertsToRoman(90, "XC");
            assertConvertsToRoman(100, "C");
            assertConvertsToRoman(400, "CD");
            assertConvertsToRoman(500, "D");
            assertConvertsToRoman(900, "CM");
            assertConvertsToRoman(1000, "M");

            assertConvertsToRoman(1500, "MD");
            assertConvertsToRoman(280, "CCLXXX");
            assertConvertsToRoman(89, "LXXXIX");
        }

        private void assertConvertsToRoman(int number, string romanNumber) 
        {
            Assert.That(romanNumbers.ToRoman(number), Is.EqualTo(romanNumber));
        }


    }
}
