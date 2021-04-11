using System;
using System.Collections.Generic;

namespace PrimeServices
{
    public class PrimeService
    {
        public static int GetPrime(int n)
        {
            if (n < 1) return -1;

            List<int> Primes = new List<int>();
            HashSet<int> nonPrimes = new HashSet<int>();
            Dictionary<int, int> primeFactors = new Dictionary<int, int>();

            for (int i = 2; Primes.Count < n; i++)
            {
                if (!nonPrimes.Contains(i)) // Naively checking if our 'nonPrimes' set contains 'i'
                {
                    Primes.Add(i);
                    primeFactors[i] = i; // A prime number is it's own prime factor
                }

                // '<=' allows a prime number to multiplied by itself (Ex. 2 * 2 = 4) 
                // '<' would prevent numbers that are squares of primes from being added to the prime array
                for (int j = 0; j < Primes.Count && Primes[j] <= primeFactors[i]; j++)
                {
                    nonPrimes.Add(Primes[j] * i);
                    primeFactors[i * Primes[j]] = Primes[j];
                }
            }

            return Primes[Primes.Count - 1];
        }
    }
}
