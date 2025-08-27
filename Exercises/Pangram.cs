using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panagram
{
    public static class Pangram
    {
        public static bool IsPangram1(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            string letters = "abcdefghijklmnopqrstuvwxyz";
            input = input.ToLower();

            return letters.All(i => input.Contains(i));
        }
        public static bool IsPangram2(string input)
        {
            HashSet<char> matches = new();
            foreach (char c in input.ToLower())
            {
                if (Char.IsLetter(c))
                    matches.Add(c);
            }

            return matches.Count == 26;
        }
        public static bool IsPangram3(string input)
        {
            HashSet<char> matches = new(input.ToLowerInvariant().Where(c => Char.IsLetter(c)));
            return matches.Count == 26;
        }
        public static bool IsPangram(string input) => input.ToLowerInvariant().Where(c => Char.IsLetter(c)).Distinct().Count() == 26;

        
    }
}
