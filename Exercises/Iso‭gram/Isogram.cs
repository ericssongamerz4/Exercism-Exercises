namespace Exercism_Exercises.Exercises.Isogram
{
    public static class Isogram
    {
        public static bool IsIsogram1(string word)
        {
            word = word.ToLower();
            HashSet<char> letters = new(word.Where(char.IsLetter));
            return letters.Count == word.Where(x => char.IsLetter(x)).Count();
        }
        public static bool IsIsogram(string word) => word.Where(char.IsLetter).Select(char.ToLower).GroupBy(c => c).All(x => x.Count() == 1);
    }
}
