using System;

namespace UnitTestKataLeapYear
{
    public class LeapYearChecker
    {
        public bool IsLeap(int yearToCheck)
        {
            if (yearToCheck < 0) throw new YearExceptionNotNegativePossible("Year not valid, is not allowed negative years");
            
            if (yearToCheck % 400 == 0) return true;
            else if (yearToCheck % 100 == 0) return false;
            else if (yearToCheck % 4 == 0) return true;
            else return false;
        }
    }
}