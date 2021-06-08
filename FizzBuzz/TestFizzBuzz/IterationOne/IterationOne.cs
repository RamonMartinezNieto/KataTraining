using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestFizzBuzz
{
    public class Tests
    {
        FizzBuzz fizzBuzz;
        Dictionary<int, string> fizzBuzzResults;

        //Givn - When - Then
        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void Init_FizzBuzz() {
            new FizzBuzz();
        }

        [Test]
        public void Call_Method_ToGetResutls() 
        {
            fizzBuzz.GetArrayFizzBuzz(100);
        }

        [Test]
        public void GivenANumber_CallMethodFizzBuzz_ReturnDictionaryWithResults() 
        {
            Dictionary<int,string> fizzBuzzResults = fizzBuzz.GetArrayFizzBuzz(50);
            Assert.That(fizzBuzzResults.Count, Is.EqualTo(50));
        }


        [Test]
        public void CallingFizzBuzz_NumberDivisbleBy3_IsFizz()
        {
            fizzBuzzResults = fizzBuzz.GetArrayFizzBuzz(100);
            
            Assert.That(fizzBuzzResults.Count, Is.EqualTo(100));
            Assert.That(fizzBuzzResults[6], Is.EqualTo("Fizz"));
            Assert.That(fizzBuzzResults[9], Is.EqualTo("Fizz"));
            Assert.That(fizzBuzzResults[12], Is.EqualTo("Fizz"));
        }

        [Test]
        public void CallingFizzBuzz_NumberDivisbleBy5_IsBuzz()
        {
            fizzBuzzResults = fizzBuzz.GetArrayFizzBuzz(100);

            Assert.That(fizzBuzzResults.Count, Is.EqualTo(100));
            Assert.That(fizzBuzzResults[100], Is.EqualTo("Buzz"));
        }

        [Test]
        public void CallingFizzBuzz_NumberDivisibleBy5And3_IsFizzBuzz() {
            fizzBuzzResults = fizzBuzz.GetArrayFizzBuzz(100);

            Assert.That(fizzBuzzResults.Count, Is.EqualTo(100));
            Assert.That(fizzBuzzResults[15], Is.EqualTo("FizzBuzz"));
        }

    }
}