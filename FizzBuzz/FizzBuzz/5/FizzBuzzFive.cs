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

        public string[] GetResultsInArray()
        {
            string[] arrayFilled = new string[LENGHT_ARRAY];

            for (int i = 0; i < arrayFilled.Length; i++) 
            {
                if ((i + 1) % 15 == 0) arrayFilled[i] = "FizzBuzz";
                else if ((i + 1) % 5 == 0) arrayFilled[i] = "Buzz";
                else if ((i + 1) % 3 == 0) arrayFilled[i] = "Fizz";
                else arrayFilled[i] = (i + 1).ToString();
            }

            return arrayFilled;
        }
    }
}