using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_Exercises.Exercises
{
    public static class NucleotideCount
    {
        public static IDictionary<char, int> Count(string sequence)
        {
            Dictionary<char, int> nucleotideCounts = new()
            {
                { 'A', 0 }, { 'C', 0 }, { 'G', 0 }, { 'T', 0 },
            };

            if (string.IsNullOrWhiteSpace(sequence))
                return nucleotideCounts;

            foreach (char nucleotide in sequence)
            {
                if (nucleotideCounts.TryGetValue(nucleotide, out int count))
                    nucleotideCounts[nucleotide]++;
                else
                    throw new ArgumentException($"{nucleotide} is not a valid nucleotide.");
            }

            return nucleotideCounts;
        }

    }
}
