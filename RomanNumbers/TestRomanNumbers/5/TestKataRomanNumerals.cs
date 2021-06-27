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
namespace TestRomanNumbers._5
{
    [TestFixture]
    class TestKataRomanNumerals
    {
        RomanNumerlsFive romanNumerals; 

        [SetUp]
        public void SetUp() 
        {
            romanNumerals = new RomanNumerlsFive();
        }

        [TestCase(1 , ExpectedResult = "I")]
        [TestCase(2, ExpectedResult = "II")]
        [TestCase(3, ExpectedResult = "III")]
        public string ShouldBeASetofTheFirstRomanNumeral(int input) 
        {
            return romanNumerals.GetRomanNumeral(input);
        }

        [TestCase(4, ExpectedResult = "IV")]
        [TestCase(5, ExpectedResult = "V")]
        [TestCase(6, ExpectedResult = "VI")]
        [TestCase(7, ExpectedResult = "VII")]
        [TestCase(8, ExpectedResult = "VIII")]
        public string ShouldBeASetofTheSecondRomanNumeral(int input)
        {
            return romanNumerals.GetRomanNumeral(input);
        }


        [TestCase(9, ExpectedResult = "IX")]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(11, ExpectedResult = "XI")]
        [TestCase(14, ExpectedResult = "XIV")]
        [TestCase(15, ExpectedResult = "XV")]
        [TestCase(29, ExpectedResult = "XXIX")]
        public string ShouldBeASetofTheThirdRomanNumeral(int input)
        {
            return romanNumerals.GetRomanNumeral(input);
        }


        [TestCase(40, ExpectedResult = "XL")]
        [TestCase(47, ExpectedResult = "XLVII")]
        [TestCase(50, ExpectedResult = "L")]
        [TestCase(66, ExpectedResult = "LXVI")]
        [TestCase(88, ExpectedResult = "LXXXVIII")]
        public string ShouldBeASetofTheFourthRomanNumeral(int input)
        {
            return romanNumerals.GetRomanNumeral(input);
        }

        [TestCase(90, ExpectedResult = "XC")]
        [TestCase(99, ExpectedResult = "XCIX")]
        [TestCase(100, ExpectedResult = "C")]
        [TestCase(135, ExpectedResult = "CXXXV")]
        [TestCase(234, ExpectedResult = "CCXXXIV")]
        [TestCase(367, ExpectedResult = "CCCLXVII")]
        public string ShouldBeASetofTheFifthhRomanNumeral(int input)
        {
            return romanNumerals.GetRomanNumeral(input);
        }

        [TestCase(400, ExpectedResult = "CD")]
        [TestCase(476, ExpectedResult = "CDLXXVI")]
        [TestCase(500, ExpectedResult = "D")]
        [TestCase(567, ExpectedResult = "DLXVII")]
        [TestCase(765, ExpectedResult = "DCCLXV")]
        [TestCase(879, ExpectedResult = "DCCCLXXIX")]
        public string ShouldBeASetofTheSixthRomanNumeral(int input)
        {
            return romanNumerals.GetRomanNumeral(input);
        }

        [TestCase(900, ExpectedResult = "CM")]
        [TestCase(999, ExpectedResult = "CMXCIX")]
        [TestCase(1000, ExpectedResult = "M")]
        [TestCase(1567, ExpectedResult = "MDLXVII")]
        [TestCase(2765, ExpectedResult = "MMDCCLXV")]
        [TestCase(3879, ExpectedResult = "MMMDCCCLXXIX")]
        public string ShouldBeASetofTheSeventhRomanNumeral(int input)
        {
            return romanNumerals.GetRomanNumeral(input);
        }
    }
}
