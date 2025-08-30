using System.Text;

namespace RotationalCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))

                    result.Append(ShiftChar(text[i], shiftKey));

                else
                    result.Append(text[i]);
            }

            return result.ToString();
        }
        private static char ShiftChar(char c, int shift) => char.IsUpper(c) ? Convert.ToChar((c + shift - 65) % 26 + 65) : Convert.ToChar((c + shift - 97) % 26 + 97);
    }
}
