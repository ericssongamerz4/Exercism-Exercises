using System.Globalization;

namespace Exercism_Exercises.Exercises.HighSchoolSweethearts
{
    public static class HighSchoolSweethearts
    {
        private static readonly string banner = @"
******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {0} +  {1}    **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *
";
        public static string DisplaySingleLine(string studentA, string studentB) => string.Format("{0} ♡ {1}", studentA.PadLeft(29), studentB.PadRight(29));

        public static string DisplayBanner(string studentA, string studentB) => string.Format(banner, studentA, studentB);

        public static string DisplayGermanExchangeStudents(string studentA, string studentB, DateTime start, float hours) => string.Format(new CultureInfo("de-DE"), "{0} and {1} have been dating since {2:d} - that's {3:N2} hours", studentA, studentB, start, hours);

    }

}
