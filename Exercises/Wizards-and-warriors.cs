/*
 In this exercise you're playing a role-playing game named "Wizard and Warriors," which allows you to play as either a Wizard or a Warrior.

There are different rules for Warriors and Wizards to determine how much damage points they deal.

For a Warrior, these are the rules:

Deal 6 points of damage if the character they are attacking is not vulnerable
Deal 10 points of damage if the character they are attacking is vulnerable
For a Wizard, these are the rules:

Deal 12 points of damage if the Wizard prepared a spell in advance
Deal 3 points of damage if the Wizard did not prepare a spell in advance
In general, characters are never vulnerable. However, Wizards are vulnerable if they haven't prepared a spell.

You have six tasks that work with Warriors and Wizard characters.
 

1.Override the ToString() method on the Character class to return a description of the character, formatted as "Character is a <CHARACTER_TYPE>".

2.Ensure that the Character.Vulnerable() method always returns false.

3. Implement the Wizard.PrepareSpell() method to allow a Wizard to prepare a spell in advance.

4. Ensure that the Vulnerable() method returns true if the wizard did not prepare a spell; otherwise, return false.

5.Implement the Wizard.DamagePoints() method to return the damage points dealt: 12 damage points when a spell has been prepared, 3 damage points when not.

6.Implement the Warrior.DamagePoints() method to return the damage points dealt: 10 damage points when the target is vulnerable, 6 damage points when not.

 */


abstract class Character
{
    private readonly string _characterType;

    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {_characterType}";
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
