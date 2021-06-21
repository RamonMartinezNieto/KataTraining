using NUnit.Framework;
using PrimeFactors._1;
using System.Collections.Generic;
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
*/
namespace TestPrimeFactors
{
    [TestFixture]
    public class TestsPrimeFactors
    {
        PrimeFactorsOne primeFactors;

        [SetUp]
        public void SetUp() {
            primeFactors = new PrimeFactorsOne();
        }

        [Test]
        public void CallingMethodGenerate()
        {
            List<int> primeFactorsArray = primeFactors.Generate(2);
        }

        [Test]
        public void OneShouldNotHaveFactors()
        {
            List<int> primeFactorsArray = primeFactors.Generate(1);
            Assert.That(primeFactorsArray, Is.Empty);
        }

        [TestCase(2, ExpectedResult = 2)]
        [TestCase(3, ExpectedResult = 3)]
        [TestCase(5, ExpectedResult = 5)]
        public int PrimeNumbersCannontBeDescomposed(int input)
        {
            List<int> primeFactorsArray = primeFactors.Generate(input);
            Assert.That(primeFactorsArray, Is.Not.Empty);
            return primeFactorsArray[0];
        }

        [Test]
        public void FourIs2multply2()
        {
            List<int> primeFactorsArray = primeFactors.Generate(4);
            Assert.That(primeFactorsArray, Is.Not.Empty);
            Assert.That(primeFactorsArray, Has.Exactly(2).Matches<int>(x => x == 2));
        }

        [Test]
        public void SixIs2multply3()
        {
            List<int> primeFactorsArray = primeFactors.Generate(6);
            Assert.That(primeFactorsArray, Is.Not.Empty);
            Assert.That(primeFactorsArray, Has.Exactly(1).Matches<int>(x => x == 2));
            Assert.That(primeFactorsArray, Has.Exactly(1).Matches<int>(x => x == 3));
        }

        [Test]
        public void EigthIs2mult2mult2()
        {
            List<int> primeFactorsArray = primeFactors.Generate(8);
            Assert.That(primeFactorsArray, Is.Not.Empty);
            Assert.That(primeFactorsArray, Has.Exactly(3).Matches<int>(x => x == 2));
        }

        [Test]
        public void NineIs3mult3()
        {
            List<int> primeFactorsArray = primeFactors.Generate(9);
            Assert.That(primeFactorsArray, Is.Not.Empty);
            Assert.That(primeFactorsArray, Has.Exactly(2).Matches<int>(x => x == 3));
        }

        [Test]
        public void TenIs2mult5()
        {
            List<int> primeFactorsArray = primeFactors.Generate(10);
            Assert.That(primeFactorsArray, Is.Not.Empty);
            Assert.That(primeFactorsArray, Has.Exactly(1).Matches<int>(x => x == 2));
            Assert.That(primeFactorsArray, Has.Exactly(1).Matches<int>(x => x == 5));
        }

        [Test]
        public void TwelveIs2mult2mult3()
        {
            List<int> primeFactorsArray = primeFactors.Generate(12);
            Assert.That(primeFactorsArray, Is.Not.Empty);
            Assert.That(primeFactorsArray, Has.Exactly(2).Matches<int>(x => x == 2));
            Assert.That(primeFactorsArray, Has.Exactly(1).Matches<int>(x => x == 3));
        }
    }
}