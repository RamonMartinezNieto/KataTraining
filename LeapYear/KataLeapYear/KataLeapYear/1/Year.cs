using System;

namespace UnitTestKataLeapYear
{
    public class Year
    {
        private int _currentYear;

        public int CurrentYear {

            get { return _currentYear; } 

            private set {
                if (value < 0)
                {
                    throw new YearExceptionNotNegativePossible("Year not valid, is not allowed negative years");
                }
                else {
                    _currentYear = value;
                }
            }
        }

        public Year(int year)
        {
            CurrentYear = year;
        }

        public bool IsLeap()
        {
            if (CurrentYear % 400 == 0) return true;
            if (CurrentYear % 100 == 0) return false;
            if (CurrentYear % 4 == 0) return true;
            else return false;
        }
    }
}