
using System;
namespace Exercism_Exercises.Exercises.Series
{
    public static class Series
    {
        public static string[] Slices(string numbers, int sliceLength)
        {
            if (sliceLength < 1 || sliceLength > numbers.Length)
                throw new ArgumentException($"{sliceLength} is not a valid length for slicing {numbers}.");

            List<string> result = new List<string>();

            for (int i = 0; i <= numbers.Length - sliceLength; i++)
            {
                int endPos = i + sliceLength;
                result.Add(numbers[i..endPos]);
            }

            return result.ToArray();
        }
    }
}//Made by ericssonGamerz4

