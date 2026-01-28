 public class HighScores
 {
     private readonly List<int> scoreList;
     public HighScores(List<int> list)
     {
         scoreList = list;
     }

     public List<int> Scores() => scoreList;

     public int Latest() => scoreList.Last();

     public int PersonalBest() => scoreList.Max();

     public List<int> PersonalTopThree() => scoreList.OrderByDescending(x => x).Take(3).ToList();
 }