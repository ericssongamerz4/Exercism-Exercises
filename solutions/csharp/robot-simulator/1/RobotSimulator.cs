
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

    public Direction Direction
    {
        get => direction;
        private set { }
    }

    public int X
    {
        get => x;
        private set { }
    }

    public int Y
    {
        get => y;
        private set { }

    }

    public void Move(string instructions)
    {
        foreach (var instruction in instructions)
        {
            switch (instruction)
            {
                case 'R':
                    if (direction == Direction.West)
                        direction = Direction.North;
                    else
                        direction += 1;
                    break;

                case 'L':
                    if (direction == Direction.North)
                        direction = Direction.West;
                    else
                        direction -= 1;
                    break;

                case 'A':
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
                    }
                    break;

                default:
                    throw new ArgumentException($"The '{instruction}' instruction is invalid.");
            }
        }
    }
}

