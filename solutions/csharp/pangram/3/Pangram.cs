public static class Pangram
{
               public static bool IsPangram(string input)
        {
            HashSet<char> matches = new(input.ToLowerInvariant().Where(c => Char.IsLetter(c)));
            return matches.Count == 26;
        }
}
