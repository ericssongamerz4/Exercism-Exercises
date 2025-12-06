namespace Exercism_Exercises.Exercises.ETL;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var item in old)
        {
            foreach (string letter in item.Value) 
            { 
                result.Add(letter.ToLower(), item.Key);
            }
        }
        return result;
    }
}
//Made by ericssonGamerz4       