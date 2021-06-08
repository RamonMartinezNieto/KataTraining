using System;

namespace TestFizzBuzz.IterationTwo
{
    public class FizzBuzzIterationTwo
    {
        const int ARRAY_CPACITY = 100;

        enum Rules : byte
        {
            FizzBuzz = 15,
            Fizz = 3,
            Buzz = 5
        }

        public string[] GetArrayWithResults()
        {
            string[] results = new string[ARRAY_CPACITY];

            for (int i = 1; i <= 100; i++) {
                if (i % (int)Rules.FizzBuzz == 0) results[i - 1] = Rules.FizzBuzz.ToString();
                else if (i % (int)Rules.Fizz == 0) results[i - 1] = Rules.Fizz.ToString();
                else if (i % (int)Rules.Buzz == 0) results[i - 1] = Rules.Buzz.ToString();
                else results[i - 1] = i.ToString();
            }
            
            return results;
        }
    }
}