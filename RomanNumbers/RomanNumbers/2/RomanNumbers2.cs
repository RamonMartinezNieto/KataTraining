using System;
using System.Collections.Generic;

namespace TestRomanNumbers._2
{
    public class RomanNumbers2
    {
        Dictionary<string, int> rulesRomanNumbers = new Dictionary<string, int>()
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

        public string ConvertToRomanNumber(int number)
        {
            string romanNumber = string.Empty;
            if (number <= 0) throw new Exception("Invalid number");
  
            foreach (KeyValuePair<string, int> rule in rulesRomanNumbers) 
            {
                while (number >= rule.Value)
                {
                    romanNumber += rule.Key;
                    number -= rule.Value;
                }
            }
            return romanNumber;
        }
    }
}