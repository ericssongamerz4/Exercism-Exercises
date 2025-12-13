using System;

namespace Exercism_Exercises.Exercises.Sieve;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        List<int> result = new();

        for (int i = 2; i <= limit; i++)
        {
            if(IsPrime(i))
                result.Add(i);
        }
        return result.ToArray();
    }

    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(num));
        for (int i = 3; i <= boundary; i += 2)
            if (num % i == 0)
                return false;
        return true;
    }
}
//Made by ericssonGamerz4      