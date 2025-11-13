[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly Allergen UserAllergies;

    public Allergies(int mask)
    {
        UserAllergies = (Allergen) mask;      
    }

    public bool IsAllergicTo(Allergen allergen) => UserAllergies.HasFlag(allergen);

    public Allergen[] List() => Enum.GetValues(typeof(Allergen))
                                    .Cast<Allergen>()
                                    .Where(allergen => UserAllergies.HasFlag(allergen))
                                    .ToArray();
}
//Made by ericssonGamerz4

