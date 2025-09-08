namespace Exercism_Exercises.Exercises.Raindrops
{
    public static class Raindrops
    {
        private static readonly Dictionary<int, string> rainSounds = new()
        {
            {3, "Pling"},{5,"Plang"},{7, "Plong"},
        };

        public static string Convert(int number)
        {
            string result = String.Concat(rainSounds.Where(sound => number % sound.Key == 0)
                                                    .Select(sound => sound.Value));

            return (string.IsNullOrEmpty(result)) ? number.ToString() : result.ToString();
        }
    }

}//Made by ericssongamerz4

                