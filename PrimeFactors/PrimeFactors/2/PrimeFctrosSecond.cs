using System;
using System.Collections.Generic;

namespace TestPrimeFactors._2
{
    public class PrimeFctrosSecond
    {
        public List<int> GetPrimeFactors(int number)
        {
            List<int> primeNumbersList = new List<int>();

            if (number == 1) primeNumbersList.Add(1);

            for (int i = 2; i <= number; i++) 
            {
                while (number % i == 0) 
                {
                    primeNumbersList.Add(i);
                    number /= i;
                }
            }
            return primeNumbersList;
        }
    }
}