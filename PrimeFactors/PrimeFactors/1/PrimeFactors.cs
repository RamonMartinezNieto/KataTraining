
using System;
using System.Collections.Generic;

namespace PrimeFactors._1
{
    public class PrimeFactorsOne
    {
        public PrimeFactorsOne() { }

        public List<int> Generate(int number)
        {
            List<int> primeFactors = new List<int>();
            int divisor = 2;

            while (number > 1)
            {
                while (number % divisor == 0)
                {
                    primeFactors.Add(divisor);
                    number = number / divisor;
                }
                divisor++;
            }
            return primeFactors;
        }
    }
}
