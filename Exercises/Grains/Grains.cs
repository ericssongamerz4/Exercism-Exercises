namespace Exercism_Exercises.Exercises.Grains
{
    public static class Grains
    {
        public static ulong Square(int n)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(n, 1);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(n, 64);

            return (ulong)Math.Pow(2, n - 1);
        }

        public static ulong Total()
        {
            ulong result = 0;
            for (int i = 1; i <= 64; i++) 
            {
                result += Square(i);
            }
            return result ;
        }
    }
}//Made by ericssonGamerz4

