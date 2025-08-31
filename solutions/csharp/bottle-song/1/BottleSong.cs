using System.Collections.Generic;

 public static class BottleSong
 {
     public static IEnumerable<string> Recite(int startBottles, int takeDown)
     {
         List<string> result = new List<string>();
         for (int i = startBottles; i > startBottles - takeDown ; i--)
         {
             result.Add(FirstLine(i));
             result.Add(FirstLine(i));
             result.Add(ThirdLine(i));
             result.Add(LastLine(i));
             result.Add("");
         }

         result.RemoveAt(result.Count-1);

         return result;
     }

     private static readonly string[] numbers = new string[] { "no", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", };
     private static string FirstLine(int bottleNumber) => $"{numbers[bottleNumber]} green {Plural(bottleNumber)} hanging on the wall,";
     private static string ThirdLine(int bottleNumber) => $"And if one green bottle should accidentally fall,";
     private static string LastLine(int bottleNumber) => $"There'll be {numbers[bottleNumber - 1].ToLower()} green {Plural(bottleNumber-1)} hanging on the wall.";
     private static string Plural(int bottleNumber) => (bottleNumber != 1) ? "bottles" : "bottle";

 }