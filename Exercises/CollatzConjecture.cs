namespace Exercism_Exercises.Exercises
{
    public static class CollatzConjecture
    {
        public static int Steps(int number)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException($"The {number} has to be greater than 0.");
            else
            {
                int steps = 0;
                while (number != 1)
                {
                    number = (number % 2 == 0) ? number / 2 : (number * 3) + 1;
                    steps++;
                }
                return steps;
            }
        }
    }
}
