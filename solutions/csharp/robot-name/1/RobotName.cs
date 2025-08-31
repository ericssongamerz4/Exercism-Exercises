    public class Robot
    {
        private static Random _random = new Random();
        private static HashSet<string> _robotNamesList = new HashSet<string>();

        protected string name = GenerateRobotName();

        public string Name
        {
            get
            {
                return name;
            }
        }

        public void Reset()
        {
            _robotNamesList.Remove(Name);
            name = GenerateRobotName();
        }

        private static string GenerateRobotName()
        {
            if (_robotNamesList.Count == 676000)//670000 are all the posible combinations for the robot names.
                throw new Exception("There are no more robot names that can generate.");

            string result = string.Concat(GenerateLetter(), GenerateLetter(), GenerateNumber(), GenerateNumber(), GenerateNumber());

            if (_robotNamesList.Add(result))
                return result;
            else
                return GenerateRobotName();
        }

        private static char GenerateLetter() => (char)_random.Next(65, 91);
        private static int GenerateNumber() => _random.Next(0, 10);
    }