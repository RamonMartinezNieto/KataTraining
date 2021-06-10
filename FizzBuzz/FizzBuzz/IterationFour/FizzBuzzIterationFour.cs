using System;

namespace TestFizzBuzz.IterationFour
{
    public class FizzBuzzIterationFour
    {
        private const int LENGTH_ARRAY = 100;

        public enum RULES : int { 
            Fizz = 3,
            Buzz = 5,
            FizzBuzz = 15,
            FizzBuzz50 = 50
        }

        public string[] GetResults()
        {
            string[] results = new string[LENGTH_ARRAY];
            for (int i = 0; i < 100; i++) {
                results[i] = (i + 1).ToString();
                foreach (RULES r in Enum.GetValues(typeof(RULES))) {
                    if ((i + 1) % (int)r == 0) results[i] = r.ToString();
                }
            }
            return results;
        }
    }
}