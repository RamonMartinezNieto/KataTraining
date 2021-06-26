using System;
using System.Collections.Generic;

namespace TestRomanNumbers._4
{
    public class RomanNumeralsFour
    {

        Dictionary<string, int> rules = new Dictionary<string, int>()
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

        public string GetRomanNumer(int algebraicNumber)
        {
            string romanNumber = string.Empty;
            foreach (KeyValuePair<string,int> rules in rules) 
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