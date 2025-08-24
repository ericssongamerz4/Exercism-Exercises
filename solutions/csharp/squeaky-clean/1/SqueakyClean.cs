using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (string.IsNullOrEmpty(identifier))
            return identifier;

        identifier = ConvertKebabToCamel(identifier);

        StringBuilder sb = new(identifier.Length);

        foreach (char c in identifier)
        {
            if (Char.IsControl(c))          
                sb.Append("CTRL");           

            else if (Char.IsWhiteSpace(c))            
                sb.Append("_");
            
            else if (char.IsLetter(c) && !c.IsGreekChar())          
                sb.Append(c);
           
        }

        return sb.ToString();
    }

    private static bool IsGreekChar(this char c) => (c >= 0x03B1 && c <= 0x03C9); // Greek Characters

    private static string ConvertKebabToCamel(string id)
    {
        var stringArray = id.Split('-');
        var output = new StringBuilder(stringArray[0]);

        for (var i = 1; i < stringArray.Length; i++)
        {
            output.Append(char.ToUpper(stringArray[i][0]) + stringArray[i].Substring(1));
        }

        return output.ToString();
    }

}






