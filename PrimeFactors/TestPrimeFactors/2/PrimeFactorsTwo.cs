using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPrimeFactors._2
{
    /*
    * Class with a generate method that return a list with the prime facotrs of int number.
    * 
    * E.G: 
    * 
    * 2 : [2]
    * 3 : [3]
    * 6 : [2,3]
    * 8 : [2,2,2]
    * 12 : [2,2,3]
    * 
    * Som tips
    * The number doesn't have a factor prime (1) 
    * Numbers that are prime number (such as 2,3,5)
    * Numbers that are product of a prime numbers (4,6,12,15)
    * 
    * Remember: A prime number is a counting number which can't be divided, except by 1 or itself
    * 
    */
    class PrimeFactorsTwo
    {
        PrimeFctrosSecond primeFactors;
        
        [SetUp]
        public void SetUp()
        {
            primeFactors = new PrimeFctrosSecond();
        }

        [Test]
        public void ShouldBeOneTheNumberThatDoesnthaveAFactorPrime() 
        {
            CollectionAssert.AreEquivalent(primeFactors.GetPrimeFactors(1), new List<int>() {  });
        }

        [Test]
        public void NumbersThatArePrimeNumberShouldBeTheSameNumber([Values(2,3,5,7,11,23,47,73)] int input)
        {
            CollectionAssert.AreEquivalent(primeFactors.GetPrimeFactors(input), new List<int>() { input });
        }

        [Test]
        public void FourIsShouldBeAListWith2and2()
        {
            CollectionAssert.AreEquivalent(
                primeFactors.GetPrimeFactors(4),
                new List<int>() { 2, 2 });
        }

        
        [Test]
        public void TenIsShouldBeAListWith25()
        {
            CollectionAssert.AreEquivalent(
                primeFactors.GetPrimeFactors(10), 
                new List<int>() { 2 , 5 });
        }

        [Test]
        public void FifteenShouldBe3and5()
        {
            CollectionAssert.AreEquivalent(
                primeFactors.GetPrimeFactors(15),
                new List<int>() { 3, 5 });
        }
    }
}
