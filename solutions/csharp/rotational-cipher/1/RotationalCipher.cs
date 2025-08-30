using System.Text;

    public static class RotationalCipher
    {
        private static readonly char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public static string Rotate(string text, int shiftKey)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    if (char.IsUpper(text[i]))
                    {

                        int shiftValue = ((int)text[i] + shiftKey - 65) % 26;
                        result.Append(char.ToUpper(alphabet[shiftValue]));

                    }
                    else
                    {
                        int shiftValue = ((int)text[i] + shiftKey -97) % 26;
                        result.Append(alphabet[shiftValue]);
                    }
                }
                else 
                {
                    result.Append(text[i]);
                }
            }

            return result.ToString();
        }
    }