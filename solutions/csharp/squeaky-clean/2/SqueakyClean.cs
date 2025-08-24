using System.Text;

    public static class Identifier
    {
        public static string Clean(string identifier)
        {
            if (string.IsNullOrEmpty(identifier))
                return identifier;

            bool capitalizeNext = false;

            StringBuilder sb = new(identifier.Length);

            foreach (char c in identifier)
            {
                if (Char.IsControl(c))
                {
                    sb.Append("CTRL");
                    capitalizeNext = false;
                }

                else if (Char.IsWhiteSpace(c))
                {
                    sb.Append("_");
                    capitalizeNext = false;
                }

                else if(c == '-')
                {
                    capitalizeNext = true;
                }

                else if (char.IsLetter(c) && !c.IsGreekChar())
                {
                    sb.Append(capitalizeNext ? char.ToUpper(c) : c);
                    capitalizeNext = false;
                }

            }

            return sb.ToString();
        }

        private static bool IsGreekChar(this char c) => (c >= 0x03B1 && c <= 0x03C9); // Lower Case Greek Characters

    }




