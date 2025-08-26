public static class Pangram
{
        public static bool IsPangram(string input)
        {
            if(string.IsNullOrEmpty(input)) return false;

            char[] charsToCheck =
            [
                'a',
                'b',
                'c',
                'd',
                'e',
                'f',
                'g',
                'h',
                'i',
                'j',
                'k',
                'l',
                'm',
                'n',
                'o',
                'p',
                'q',
                'r',
                's',
                't',
                'u',
                'v',
                'w',
                'x',
                'y',
                'z',
            ];

            return charsToCheck.All(i => input.ToLower().Contains(i));
        }
}
