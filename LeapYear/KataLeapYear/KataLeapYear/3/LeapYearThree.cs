using System;

namespace UnitTestKataLeapYear._3
{
    public class LeapYearThree
    {
        public bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            else if (year % 100 == 0) return false;
            else if (year % 4 == 0) return true;
            return false;
        }
    }
}