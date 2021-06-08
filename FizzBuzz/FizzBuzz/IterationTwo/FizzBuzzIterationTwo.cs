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
                results[i - 1] = i.ToString();
                foreach (Rules valRule in Enum.GetValues(typeof(Rules))) {
                    if (i % (int)valRule == 0)  results[i - 1] = valRule.ToString();
                }
            }
            return results;
        }
    }
}