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