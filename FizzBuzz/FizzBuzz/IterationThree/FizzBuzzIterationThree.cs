using System;

namespace TestFizzBuzz.IterationThree
{
    public class FizzBuzzIterationThree
    {
        public const int ARRAY_LENGHT = 100;

        public string[] GetResultsFizzBuzz()
        {
            string[] results = new string[ARRAY_LENGHT];

            for (int i = 0; i < ARRAY_LENGHT; i++) {
                if ((i + 1) % 15 == 0) results[i] = "FizzBuzz";
                else if ((i + 1) % 3 == 0) results[i] = "Fizz";
                else if ((i + 1) % 5 == 0) results[i] = "Buzz";
                else results[i] = (i + 1).ToString();
            }
            return results;
        }
    }
}