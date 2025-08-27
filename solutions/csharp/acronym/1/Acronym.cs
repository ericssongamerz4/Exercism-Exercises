 public static class Acronym
 {
     public static string Abbreviate(string phrase)
     {
         phrase = phrase.Replace('-', ' ').Replace('_', ' ');
         var words = phrase.Split(' ');
         string result = "";

         foreach (var word in words)
         {
             if (!string.IsNullOrWhiteSpace(word))
                 result += word[0].ToString();
         }

         return result.ToUpper();
     }     
 }