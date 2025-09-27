namespace Exercism_Exercises.Exercises.DndCharacter
{
    public class DndCharacter
    {
        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Constitution { get; private set; }
        public int Intelligence { get; private set; }
        public int Wisdom { get; private set; }
        public int Charisma { get; private set; }
        public int Hitpoints { get; private set; }

        public static int Modifier(int score) => (int)Math.Floor((score - 10) / 2D);

        public static int Ability()
        {
            List<int> diceRolls =
            [
                DiceRoll(),
                DiceRoll(),
                DiceRoll(),
                DiceRoll(),
            ];

            diceRolls.Remove(diceRolls.Min());

            return diceRolls.Sum();
        }

        private static readonly Random random = new Random();
        private static int DiceRoll() => random.Next(1, 7);

        public static DndCharacter Generate()
        {
            int constitution = Ability();

            return new DndCharacter()
            {
                Strength = Ability(),
                Dexterity = Ability(),
                Constitution = constitution,
                Intelligence = Ability(),
                Wisdom = Ability(),
                Charisma = Ability(),
                Hitpoints = 10 + Modifier(constitution),
            };
        }
    }
}//Made by ericssonGamerz4

