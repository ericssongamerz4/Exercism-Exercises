namespace Exercism_Exercises.Exercises.KindergartenGarden
{
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
            int startingPos = studentIndex * 2;

            foreach (var diagram in plantsDiagram)
            {
                yield return diagramEncoding.GetValueOrDefault(diagram[startingPos]);
                yield return diagramEncoding.GetValueOrDefault(diagram[startingPos+1]);
            }
        }
    }
}//Made by ericssonGamerz4

