/*
 * Return Fizz if the number is divisible by 3.
 * Return Buzz  if the number is divisible by 5.
 * Return FizzBuzz  if the number is divisible by 3 & 5.
 */

using System;

namespace TestFizzBuzz._5
{
    public class FizzBuzzFive
    {
        public const int LENGHT_ARRAY = 100;
        public string[] arrayFilled; 

        public enum RULES : int 
        {
            FizzBuzz = 15,
            Buzz = 5,
            Fizz = 3
        }

        public string[] GetResultsInArray()
        {
            string[] arrayFilled = new string[LENGHT_ARRAY];

            for (int i = 0; i < arrayFilled.Length; i++) 
            {
                arrayFilled[i] = (i + 1).ToString();
                foreach (RULES r in Enum.GetValues(typeof(RULES)))
                {
                    if ((i + 1) % (int)r == 0) arrayFilled[i] = r.ToString();
                }
            }

            return arrayFilled;
        }
    }
}