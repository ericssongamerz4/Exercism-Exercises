public static class FoodChain
{
    private static readonly string First = "I know an old lady who swallowed a fly.\n";
    private static readonly string FirstLastVerse = "I don't know why she swallowed the fly. Perhaps she'll die.";

    private static readonly string Second = "I know an old lady who swallowed a spider.\n" +
                                            "It wriggled and jiggled and tickled inside her.\n";
    private static readonly string SecondLastVerse = "She swallowed the spider to catch the fly.\n";

    private static readonly string Third = "I know an old lady who swallowed a bird.\n" +
                                           "How absurd to swallow a bird!\n";
    private static readonly string ThirdLastVerse = "She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\n";

    private static readonly string Forth = "I know an old lady who swallowed a cat.\n" +
                                           "Imagine that, to swallow a cat!\n";
    private static readonly string ForthLastVerse = "She swallowed the cat to catch the bird.\n";

    private static readonly string Fifth = "I know an old lady who swallowed a dog.\n" +
                                           "What a hog, to swallow a dog!\n";
    private static readonly string FifthLastVerse = "She swallowed the dog to catch the cat.\n";

    private static readonly string Sixth = "I know an old lady who swallowed a goat.\n" +
                                           "Just opened her throat and swallowed a goat!\n";
    private static readonly string SixthLastVerse = "She swallowed the goat to catch the dog.\n";

    private static readonly string Seventh = "I know an old lady who swallowed a cow.\n" +
                                              "I don't know how she swallowed a cow!\n";
    private static readonly string SeventhLastVerse = "She swallowed the cow to catch the goat.\n";

    private static readonly string Last = "I know an old lady who swallowed a horse.\n" +
                                          "She's dead, of course!";

    private static readonly List<string> Song = new List<string>()
    {
        "",
        First + FirstLastVerse,
        Second + SecondLastVerse + FirstLastVerse,
        Third + ThirdLastVerse + SecondLastVerse + FirstLastVerse,
        Forth + ForthLastVerse + ThirdLastVerse + SecondLastVerse + FirstLastVerse,
        Fifth + FifthLastVerse + ForthLastVerse + ThirdLastVerse + SecondLastVerse + FirstLastVerse,
        Sixth + SixthLastVerse + FifthLastVerse + ForthLastVerse + ThirdLastVerse + SecondLastVerse + FirstLastVerse,
        Seventh + SeventhLastVerse + SixthLastVerse + FifthLastVerse + ForthLastVerse + ThirdLastVerse + SecondLastVerse + FirstLastVerse,
        Last,
    };

    public static string Recite(int verseNumber) => Song[verseNumber];

    public static string Recite(int startVerse, int endVerse)
    {
        string result = "";

        foreach (string verse in Song.GetRange(startVerse, endVerse))
        {
            result += verse;
            if (verse != Recite(endVerse))
                result += "\n\n";
        }
        return result;
    }
}