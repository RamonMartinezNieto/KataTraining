using System;
using System.Collections.Generic;

namespace TestRomanNumbers._3
{
    public class RomanNumeralsThree
    {
        Dictionary<string, int> rulesRomanNumerals = new Dictionary<string, int>()
        {
            { "M", 1000 },
            { "CM", 900 },
            { "D", 500 },
            { "CD", 400 },
            { "C", 100 },
            { "XC", 90 },
            { "L", 50 },
            { "XL", 40 },
            { "X", 10 },
            { "IX", 9 },
            { "V", 5 },
            { "IV", 4 },
            { "I", 1 }
        };

        public string ConvertToRomanNumber(int algebraicNumber)
        {
            string romanNumber = string.Empty;

            foreach (KeyValuePair<string, int> rules in rulesRomanNumerals) 
            {
                while (algebraicNumber >= rules.Value)
                {
                    romanNumber += rules.Key;
                    algebraicNumber -= rules.Value;
                }
            }

            return romanNumber;
        }
    }
}