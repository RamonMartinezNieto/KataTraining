using System;

namespace UnitTestKataLeapYear._2
{
    public class LeapYearDos
    {
        public bool IsLeap(int year)
        {
            if (year < 0) throw new NegativeYearException("Year can't be negative.");
            if (year % 400 == 0) return true;
            else if (year % 100 == 0) return false;
            else if (year % 4 == 0) return true;
            return false;
            
        }
    }
}