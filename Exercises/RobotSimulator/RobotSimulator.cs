namespace Exercism_Exercises.Exercises.RobotSimulator
{
    public enum Direction
    {
        North,
        East,
        South,
        West
    }

    public class RobotSimulator
    {
        private int x, y;
        private Direction direction;

        public RobotSimulator(Direction direction, int x, int y)
        {
            this.direction = direction;
            this.x = x;
            this.y = y;
        }

        public Direction Direction => direction;

        public int X => x;

        public int Y => y;

        public void Move(string instructions)
        {
            foreach (var instruction in instructions)
            {
                switch (instruction)
                {
                    case 'R':
                        direction = (Direction)(((int)direction + 1) % 4);
                        break;

                    case 'L':
                        direction = (Direction)(((int)direction + 3) % 4);
                        break;

                    case 'A':
                        Advance();
                        break;

                    default:
                        throw new ArgumentException($"The '{instruction}' instruction is invalid.");
                }
            }
        }

        private void Advance()
        {
            switch (direction)
            {
                case Direction.North:
                    y += 1;
                    break;
                case Direction.East:
                    x += 1;
                    break;
                case Direction.South:
                    y -= 1;
                    break;
                case Direction.West:
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException($"The direction is invalid.");
            }
        }
    }
}//Made by ericssonGamerz4
