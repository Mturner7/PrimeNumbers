using System;
using System.Collections.Generic;

namespace PrimeServices
{
    public class PrimeService
    {
        public static int GetPrime(int n)
        {
            bool flag = true;
            List<int> Primes = new List<int>() { 2 };

            for (int i = 3; Primes.Count < n; i++)
            {
                for (int j = 0; j < Primes.Count; j++)
                {
                    if (i % Primes[j] == 0)
                    {
                        flag = false;
                        break;
                    }

                    flag = true;
                }

                if (flag) Primes.Add(i);
            }

            return Primes[Primes.Count - 1];
        }
    }
}
