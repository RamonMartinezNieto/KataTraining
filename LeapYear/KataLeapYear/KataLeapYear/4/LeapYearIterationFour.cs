using System;

namespace UnitTestKataLeapYear._4
{
    public class LeapYearIterationFour
    {
        public bool IsLeap(int number)
        {
            if (number % 400 == 0) return true;
            if (number % 100 == 0) return false;
            if (number % 4 == 0) return true;
            return false;
        }
    }
}