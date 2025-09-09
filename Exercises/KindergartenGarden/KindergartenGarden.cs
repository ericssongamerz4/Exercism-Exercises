namespace Exercism_Exercises.Exercises.KindergartenGarden
{
    public enum Plant
    {
        Violets = 'V',
        Radishes = 'R',
        Clover = 'C',
        Grass = 'G'
    }
    public class KindergartenGarden
    {
        private readonly List<string> students =
        [
            "Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry",
        ];
        private readonly IReadOnlyList<string> plantsDiagram;

        public KindergartenGarden(string diagram) => plantsDiagram = diagram.Split('\n');

        public IEnumerable<Plant> Plants(string student)
        {            
            int studentIndex = students.IndexOf(student);

            if (studentIndex == -1)
                throw new ArgumentException($"{student} does not exist.");

            int startingPos = studentIndex * 2;

            foreach (string row in plantsDiagram)
            {
                yield return (Plant) row[startingPos];
                yield return (Plant) row[startingPos + 1];
            }
        }
    }
}//Made by ericssonGamerz4

