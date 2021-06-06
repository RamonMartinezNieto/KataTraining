using System;

namespace UnitTestKataLeapYear._2
{
    public class NegativeYearException : Exception
    {
        public NegativeYearException(string message) : base(message)
        {
        }
    }
}