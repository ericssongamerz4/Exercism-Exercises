namespace Exercism_Exercises.Exercises
{
    public static class ScrabbleScore
    {
        public static int Score(string input)
        {
            int score = 0;
            foreach (char c in input.ToUpperInvariant())
            {
                score += c switch
                {
                    'A' or 'E' or 'I' or 'O' or 'U' or 'L' or 'N' or 'R' or 'S' or 'T' => 1,
                    'D' or 'G' => 2,
                    'B' or 'C' or 'M' or 'P' => 3,
                    'F' or 'H' or 'V' or 'W' or 'Y' => 4,
                    'K' => 5,
                    'J' or 'X' => 8,
                    'Q' or 'Z' => 10,
                    _ => throw new ArgumentException($"{input} has invalid charcters."),
                };
            }
            return score;
        }
    }
}
