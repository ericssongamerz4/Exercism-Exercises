public static class ResistorColorTrio
{
    private static readonly Dictionary<string, int> resistorColors = new()
    {
        {"black",0 }, {"brown", 1}, {"red", 2}, {"orange", 3}, {"yellow", 4}, {"green",5 }, {"blue",6}, {"violet",7 }, {"grey", 8}, {"white", 9},
    };
    public static string Label(string[] colors)
    {
        string result = "";

        for (int i = 0; i <= 2; i++)
        {
            int colorValue = GetColorValueFromResistor(colors[i]);

            result += (i < 2) ? colorValue : string.Concat(Enumerable.Repeat(0, colorValue));
        }

        return GetPrefixString(Convert.ToInt64(result));
    }

    private static int GetColorValueFromResistor(string color) => resistorColors.GetValueOrDefault(color);

    private static string GetPrefixString(long value) => value switch
    {
        >= 1000000000 => $"{value / 1000000000} gigaohms",
        >= 1000000 => $"{value / 1000000} megaohms",
        >= 1000 => $"{value / 1000} kiloohms",
        _ => $"{value} ohms",
    };
}

//Made by ericssonGamerz4