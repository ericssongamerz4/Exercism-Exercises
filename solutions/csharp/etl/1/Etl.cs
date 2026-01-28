public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var valuePair in old)
        {
            foreach (string letter in valuePair.Value) 
            { 
                result.Add(letter.ToLower(), valuePair.Key);
            }
        }
        return result;
    }
}

//Made by ericssonGamerz4
    