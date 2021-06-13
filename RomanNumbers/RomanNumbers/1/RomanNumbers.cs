using System;
using System.Collections.Generic;

namespace TestRomanNumbers._1
{
    public class RomanNumbers
    {
        public Dictionary<int, string> romanRules = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        public string ToRoman(int numberCount) 
        {
            string romanNumber = "";
            foreach (KeyValuePair<int,string> entry in romanRules)
            {
                while (numberCount >= entry.Key)
                {
                    romanNumber += entry.Value;
                    numberCount -= entry.Key;
                }
            }
            return romanNumber;
        }
    }
}