using System;
using System.Collections.Generic;

namespace TestRomanNumbers._5
{
    public class RomanNumerlsFive
    {
        Dictionary<string, int> romanRules = new Dictionary<string, int>()
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

        public string GetRomanNumeral(int number)
        {
            string romanNumeral = string.Empty;

            foreach (KeyValuePair<string, int> romanRule in romanRules) 
            {
                while (number >= romanRule.Value)
                {
                    romanNumeral += romanRule.Key;
                    number -= romanRule.Value;
                }
            }

            return romanNumeral;
        }
    }
}