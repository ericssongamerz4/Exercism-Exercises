using System;

namespace Exercism_Exercises.Exercises.TwelveDays;

public static class TwelveDays
{
    private static readonly List<string> DaysStart = new List<string>()
    {
        "",
        "first",
        "second",
        "third",
        "fourth",
        "fifth",
        "sixth",
        "seventh",
        "eighth",
        "ninth",
        "tenth",
        "eleventh",
        "twelfth",
    };
    private static readonly List<string> DaysEnd = new List<string>()
    {
        "",
        "a Partridge in a Pear Tree",
        "two Turtle Doves",
        "three French Hens",
        "four Calling Birds",
        "five Gold Rings",
        "six Geese-a-Laying",
        "seven Swans-a-Swimming",
        "eight Maids-a-Milking",
        "nine Ladies Dancing",
        "ten Lords-a-Leaping",
        "eleven Pipers Piping",
        "twelve Drummers Drumming",
    };

    public static string Recite(int verseNumber) => StartSentence(verseNumber) + EndSentence(verseNumber);

    public static string Recite(int startVerse, int endVerse)
    {
        string result = string.Empty;

        for (int i = startVerse; i <= endVerse; i++)
        {
            result += Recite(i) + "\n";
        }

        return result.TrimEnd();
    }
    private static string StartSentence(int days) => $"On the {DaysStart[days]} day of Christmas my true love gave to me: ";
    private static string EndSentence(int days)
    {
        string result = string.Empty;

        while (days > 0)
        {
            if (days == 1)
                result += DaysEnd[days] + ".";

            else if (days == 2)
                result += DaysEnd[days] + ", and ";

            else
                result += DaysEnd[days] + ", ";

            days--;
        }

        return result;
    }
}
//Made by ericssonGamerz4

