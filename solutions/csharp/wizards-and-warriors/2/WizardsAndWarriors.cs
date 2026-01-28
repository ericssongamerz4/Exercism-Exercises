abstract class Character
{
    private readonly string CharacterType;

    protected Character(string characterType)
    {
        this.CharacterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {CharacterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;

}

class Wizard : Character
{
    private bool HasPreparedSpell = false;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        int damage = HasPreparedSpell ? 12 : 3;
        HasPreparedSpell = false;
        return damage;
    }

    public override bool Vulnerable() => !HasPreparedSpell;

    public void PrepareSpell() => HasPreparedSpell = true;

}
