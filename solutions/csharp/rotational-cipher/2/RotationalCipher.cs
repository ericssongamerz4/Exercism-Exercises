using System.Text;

public static class RotationalCipher
{
    private static readonly char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                if (char.IsUpper(text[i]))
                    result.Append(char.ToUpper(alphabet[((int)text[i] + shiftKey - 65) % 26]));
              
                else
                    result.Append(alphabet[((int)text[i] + shiftKey -97) % 26]);                   
            }

            else 
                result.Append(text[i]);
            
        }

        return result.ToString();
    }
}