using System;
using System.Collections.Generic;

namespace TestFizzBuzz
{
    public class FizzBuzz
    {

        public Dictionary<int,string> GetArrayFizzBuzz(int totalIterations)
        {
            Dictionary<int, string> fizzBuzzResults = new Dictionary<int, string>();

            for (int i = 1; i <= totalIterations; i++) {
                if (i % 5 == 0 && i % 3 == 0) fizzBuzzResults.Add(i, "FizzBuzz");
                else if (i % 5 == 0) fizzBuzzResults.Add(i, "Buzz");
                else if (i % 3 == 0) fizzBuzzResults.Add(i, "Fizz");
                else fizzBuzzResults.Add(i, "none");
            }

            return fizzBuzzResults;
        }
    }
}