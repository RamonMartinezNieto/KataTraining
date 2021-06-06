using NUnit.Framework;

namespace UnitTestKataLeapYear
{
    [TestFixture]
    public class TestYear
    {

        [Test]
        public void TestYearIsLeapTrue() {
            Year year = new Year(2020);  //2020 es bisiesto
            Assert.AreEqual(true, year.IsLeap());
        }

        [Test]
        public void TestYearIsLeapFalse()
        {
            Year year = new Year(2021);  //2021 NO es bisiesto
            Assert.AreEqual(false, year.IsLeap());
        }

        [Test]
        public void TestYearIsLeapFalseYearsDivisibleBy100() {
            Year year = new Year(1900);  //1900 NO es bisiesto
            Assert.AreEqual(false, year.IsLeap());
        }

        [Test]
        public void TestYearIsLeapFalseYearsDivisibleBy400()
        {
            Year year = new Year(2000);  //2000 SI es bisiesto
            Assert.AreEqual(true, year.IsLeap());
        }

        [Test]
        public void TestYearIsLeapRangeParametersOther([Range(1,4000,4)] int yearRange)
        {
            Year year = new Year(yearRange);  //100 NO es bisiesto
            Assert.AreEqual(false, year.IsLeap());
        }

        [Test]
        public void TestYearIsLeapRangeParametersOther34()
        {
            Year year = new Year(34);  //100 NO es bisiesto
            Assert.AreEqual(false, year.IsLeap());
        }

        [Test]
        public void TestYearInitWithNegativeNumbersThrowException() {

            YearExceptionNotNegativePossible yearException = 
                Assert.Throws<YearExceptionNotNegativePossible>(
                    () => { new Year(-100); }
                );
        }

        [Test]
        public void TestYearInitWithNegativeNumbersThrowExceptionMessage()
        {

            YearExceptionNotNegativePossible yearException =
                Assert.Throws<YearExceptionNotNegativePossible>(
                    () => { new Year(-100); }
                );
            Assert.AreEqual("Year not valid, is not allowed negative years", yearException.Message);
        }


    }
}