
namespace UnitTestKataLeapYear._7
{
    public class LeapYearSeven
    {
        public bool IsLeap(int year)
        {
            if (year % 400 == 0) return true;
            else if (year % 100 == 0) return false;
            else if (year % 4 == 0) return true;
            return false;
        }
    }
}