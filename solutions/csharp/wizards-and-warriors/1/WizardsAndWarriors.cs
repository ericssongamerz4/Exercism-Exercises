abstract class Character
{
    protected string CharacterType { get; set; }
    protected bool IsVulnerable { get; set; }

    protected Character(string characterType)
    {
        this.CharacterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => IsVulnerable;

    public override string ToString()
    {
        return $"Character is a {CharacterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("TODO")
    {
        CharacterType = "Warrior";
        IsVulnerable = false;
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
    
}

class Wizard : Character
{
    public Wizard() : base("TODO")
    {
        CharacterType = "Wizard";
        IsVulnerable = true;

    }

    public override int DamagePoints(Character target)
    {
        int damage = target.Vulnerable() ? 3 : 12;
        IsVulnerable = true;
        return damage;    
    }

    public void PrepareSpell() => IsVulnerable = false;

}
