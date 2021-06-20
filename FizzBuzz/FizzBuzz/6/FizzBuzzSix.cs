using System;

namespace FizzBuzz._6
{
    public class FizzBuzzSix
    {
        private const int LENGTH_ARRAY = 100;
        private readonly string[] arrayFilled;

        public FizzBuzzSix() 
        {
            arrayFilled = new string[LENGTH_ARRAY];
        }

        public enum rules : int 
        {
            FizzBuzz = 15,
            Buzz = 5, 
            Fizz = 3
        }

        public string[] GetArrayResults()
        {
            for (int i = 0; i < 100; i++) 
            {
                arrayFilled[i] = (i + 1).ToString();
                foreach (rules r in Enum.GetValues(typeof(rules)))
                {
                    if ((i + 1) % (int)r == 0) arrayFilled[i] = r.ToString();
                }
            }
            return arrayFilled;
        }
    }
}
