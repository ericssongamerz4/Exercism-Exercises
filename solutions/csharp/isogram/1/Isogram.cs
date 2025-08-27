    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            word = word.ToLower();
            HashSet<char> letters = new(word.Where(x => Char.IsLetter(x)));
            return letters.Count == word.Where(x => Char.IsLetter(x)).Count();
        }
    }
