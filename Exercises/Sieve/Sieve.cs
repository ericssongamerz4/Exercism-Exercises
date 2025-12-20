using System;

namespace Exercism_Exercises.Exercises.Sieve;

public static class Sieve
{
    // Function to return all prime numbers up to n
    public static int[] Primes(int limit)
    {        
        // Boolean array to mark primes
        bool[] prime = new bool[limit + 1];

        for (int i = 0; i <= limit; i++)
        {
            prime[i] = true;
        }

        // Sieve of Eratosthenes
        for (int p = 2; p * p <= limit; p++)
        {
            if (prime[p])
            {
                for (int i = p * p; i <= limit; i += p)
                {
                    prime[i] = false;
                }
            }
        }

        // Store primes in list
        List<int> res = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (prime[i])
            {
                res.Add(i);
            }
        }

        return res.ToArray();
    }
}
//Made by ericssonGamerz4      