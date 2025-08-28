 public static class Acronym
 {
        public static string Abbreviate(string phrase) => string.Concat(phrase.ToUpper().Split(new char[] { '-', '_', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(word => word[0]));
   
 }