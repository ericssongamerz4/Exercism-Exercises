public static class TwoFer
{
    public static string Speak(string? name = null) => (string.IsNullOrEmpty(name))? "One for you, one for me." :   $"One for {name}, one for me.";

}