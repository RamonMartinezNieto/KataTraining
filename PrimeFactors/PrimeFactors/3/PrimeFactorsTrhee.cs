using System;
using System.Collections.Generic;

namespace TestPrimeFactors._3
{
    public class PrimeFactorsTrhee
    {
        public List<int> GetPrimeFactors(int number)
        {
            List<int> primeFactors = new List<int>();

            for (int i = 2; i <= number; i++) 
            { 
                while (number % i == 0) 
                {
                    primeFactors.Add(i);
                    number /= i;
                }
            }
            return primeFactors;
        }
    }
}