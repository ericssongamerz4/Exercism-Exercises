    public enum Plant
    {
        Violets,
        Radishes,
        Clover,
        Grass
    }
    public class KindergartenGarden
    {
        private readonly List<string> students = new()
        {
            "Alice",
            "Bob",
            "Charlie",
            "David",
            "Eve",
            "Fred",
            "Ginny",
            "Harriet",
            "Ileana",
            "Joseph",
            "Kincaid",
            "Larry",
        };

        private readonly Dictionary<char, Plant> diagramEncoding = new()
        {
            {'V', Plant.Violets}, {'R', Plant.Radishes}, {'C', Plant.Clover}, {'G', Plant.Grass},
        };

        private string[] plantsDiagram;

        public KindergartenGarden(string diagram)
        {
            plantsDiagram = diagram.Split('\n');
        }

        public IEnumerable<Plant> Plants(string student)
        {
            int studentIndex = students.IndexOf(student);
            List<char> plantList = new List<char>();

            foreach (var diagram in plantsDiagram)
            {
                int startingPos = studentIndex * 2;
                plantList.Add(diagram[startingPos]);
                plantList.Add(diagram[startingPos + 1]);
            }
            var result = new List<Plant>();

            foreach (var plant in plantList)
            {
                result.Add(diagramEncoding.GetValueOrDefault(plant));
            }

            return result;
        }
    }