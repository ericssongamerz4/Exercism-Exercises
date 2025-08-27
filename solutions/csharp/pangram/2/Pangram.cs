public static class Pangram
{
       public static bool IsPangram(string input)
 {
     HashSet<char> matches = new();
     foreach (char c in input.ToLower())
     {
         if (Char.IsLetter(c))
             matches.Add(c);
     }

     return matches.Count == 26;
 }
}
