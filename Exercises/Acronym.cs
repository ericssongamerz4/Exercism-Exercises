namespace Exercism_Exercises.Exercises
{
    public static class Acronym
    {
        public static string Abbreviate1(string phrase)
        {
            var words = phrase.ToUpper().Split(new char[]{'-','_',' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                    result += word[0].ToString();
            }

            return result;
        }

        public static string Abbreviate(string phrase) => string.Concat(phrase.ToUpper().Split(new char[] { '-', '_', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(word => word[0]));

    }
}
