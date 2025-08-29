namespace Football_Match_Reports
{
    public static class PlayAnalyzer
    {
        private static readonly Dictionary<int, string> player = new()
        {
            [1] = "goalie",
            [2] = "left back",
            [3] = "center back",
            [4] = "center back",
            [5] = "right back",
            [6] = "midfielder",
            [7] = "midfielder",
            [8] = "midfielder",
            [9] = "left wing",
            [10] = "striker",
            [11] = "right wing",
        };

        public static string AnalyzeOnField(int shirtNum) => player.GetValueOrDefault(shirtNum, "UNKNOWN");

        public static string AnalyzeOffField(object report)
        {
            switch (report)
            {
                case Injury i:
                    return  $"Oh no! {i.GetDescription()} Medics are on the field.";

                case Foul f:
                    return f.GetDescription();

                case Incident i:
                    return i.GetDescription();

                case int i:
                    return $"There are {i} supporters at the match.";

                case string s:
                    return s;

                case Manager m when m.Club is not null:
                    return $"{m.Name} ({m.Club})";

                case Manager m when m.Club is null:
                    return m.Name;

                default:
                    return "";
            }
        }
    }

    public class Manager
    {
        public string Name { get; }

        public string? Club { get; }

        public Manager(string name, string? club)
        {
            this.Name = name;
            this.Club = club;
        }
    }

    public class Incident
    {
        public virtual string GetDescription() => "An incident happened.";
    }

    public class Foul : Incident
    {
        public override string GetDescription() => "The referee deemed a foul.";
    }

    public class Injury : Incident
    {
        private readonly int player;

        public Injury(int player)
        {
            this.player = player;
        }

        public override string GetDescription() => $"Player {player} is injured.";
    }
}
