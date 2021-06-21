using System;

namespace TestFizzBuzz._7
{
    public class FizzBuzzSeven
    {
        public enum rules : int 
        {
            FizzBuzz = 15,
            Buzz = 5,
            Fizz = 3
        }

        public string[] GetResults()
        {
            string[] results = new string[100];

            for (int i = 0; i < results.Length; i++) 
            {
                results[i] = (i + 1).ToString();
                foreach (rules r in Enum.GetValues(typeof(rules))) 
                {
                    if ((i + 1) % (int)r == 0) results[i] = r.ToString();
                }
            }

            return results;
        }
    }
}