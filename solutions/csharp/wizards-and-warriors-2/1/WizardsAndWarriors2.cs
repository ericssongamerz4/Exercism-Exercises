static class GameMaster
{
    private static readonly string travelMessage = "You're traveling to your destination";

    public static string Describe(Character character) => $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";

    public static string Describe(Destination destination) => $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";

    public static string Describe(TravelMethod travelMethod) => travelMethod switch
    {
        TravelMethod.Walking => $"{travelMessage} by walking.",
        TravelMethod.Horseback => $"{travelMessage} on horseback.",
        _ => throw new ArgumentException($"{travelMethod} does not exist."),
    };

                    public static string Describe(Character character, Destination destination, TravelMethod travelMethod = TravelMethod.Walking) => string.Join(' ',[Describe(character), Describe(travelMethod), Describe(destination)]);


}

class Character
{
    public string Class { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
}

class Destination
{
    public string Name { get; set; }
    public int Inhabitants { get; set; }
}

enum TravelMethod
{
    Walking,
    Horseback
}