using System;

namespace UnitTestKataLeapYear
{
    public class YearExceptionNotNegativePossible : Exception
    {
        public YearExceptionNotNegativePossible(string message) : base(message) { }
    }
}