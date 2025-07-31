using System;

abstract class Character
{
    protected Character(string characterType)
    {
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {GetType().Name}";
    }
}

class Warrior : Character
{
    public Warrior() : base("TODO")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
        {
            return 10;
        }
        else
        {
            return 6;
        }
    }
}

class Wizard : Character
{
    private bool hasPreparedSpell = false;

    public Wizard() : base("TODO")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (hasPreparedSpell)
        {
            return 12;
        }
        else
        {
            return 3;
        }
    }

    public void PrepareSpell()
    {
        hasPreparedSpell = true;
    }

    public override bool Vulnerable()
    {
        return !hasPreparedSpell;
    }

}