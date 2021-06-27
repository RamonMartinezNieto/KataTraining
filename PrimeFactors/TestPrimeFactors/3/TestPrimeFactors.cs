using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPrimeFactors._3
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
    [TestFixture]
    class TestPrimeFactors
    {
        PrimeFactorsTrhee primeFactors;

        [SetUp]
        public void SetUp() 
        {
            primeFactors = new PrimeFactorsTrhee(); 
        }

        [Test]
        public void OneDoesntHaveFactorPrime() 
        {
            List<int> primes = primeFactors.GetPrimeFactors(1);
            CollectionAssert.IsEmpty(primes);
        }

        [Test]
        public void PrimeNumbersShouldGetTheSameNumber([Values(2, 3, 5, 7, 11, 23, 47, 73)] int input)
        {
            List<int> primes = primeFactors.GetPrimeFactors(input);
            CollectionAssert.IsNotEmpty(primes);
            CollectionAssert.Contains(primes, input);
            Assert.That(primes.Count, Is.EqualTo(1));
        }

        [Test]
        public void ShouldBe2and2ForTheNumber4()
        {
            List<int> primes = primeFactors.GetPrimeFactors(4);
            CollectionAssert.IsNotEmpty(primes);
            Assert.That(primes.Count, Is.EqualTo(2));
            CollectionAssert.AreEquivalent(primes, new List<int>() { 2, 2 });
        }

        [Test]
        public void TenIsShouldBeAListWith25()
        {
            List<int> primes = primeFactors.GetPrimeFactors(10);
            CollectionAssert.IsNotEmpty(primes);
            Assert.That(primes.Count, Is.EqualTo(2));
            CollectionAssert.AreEquivalent(primes,new List<int>() { 2, 5 });
        }

        [Test]
        public void _147ShouldBe3and7and7()
        {
            List<int> primes = primeFactors.GetPrimeFactors(147);
            CollectionAssert.IsNotEmpty(primes);
            Assert.That(primes.Count, Is.EqualTo(3));
            CollectionAssert.AreEquivalent(primes, new List<int>() { 3, 7, 7 });
        }

        [Test]
        public void _330ShouldBe2and3and5and11()
        {
            List<int> primes = primeFactors.GetPrimeFactors(330);
            CollectionAssert.IsNotEmpty(primes);
            Assert.That(primes.Count, Is.EqualTo(4));
            CollectionAssert.AreEquivalent(primes, new List<int>() { 2, 3, 5, 11 });
        }

    }
}
