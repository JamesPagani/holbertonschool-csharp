using System;

///<summary>Effectiveness of an attack or heal.</summary>
public enum Modifier
{
    ///<summary>Halves the damage/healing.</summary>
    Weak,
    ///<summary>Normal damage/healing.</summary>
    Base,
    ///<summary>Increases the damage/healing by 50%</summary>
    Strong
}

///<summary>Performs all necesary hit points calculations.</summary>
public delegate void CalculateHealth(float hp);

///<summary>Applies damage/healing modifiers.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary>Stores current hit points.</summary>
public class CurrentHPArgs : EventArgs
{
    ///<summary>Stores current hit points.</summary>
    public float currentHp {get;}

    ///<summary>Creates a new instance, carrying this instance remaining hit points.</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

///<summary>A player.</summary>
public class Player
{
    // Player name
    private string name;

    // Maximum hit points
    private float maxHp;

    // Current hit points
    private float hp;

    // The status of this instance regarding its current hitpoints.    
    private string status;

    ///<summary>Check the current HP, sending a status acording to this instance's remaining hit points.</summary>
    EventHandler<CurrentHPArgs> HPCheck;

    ///<summary>Initiate a new player instance.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = this.maxHp;
        this.name = name;
        this.status = $"{this.name} is ready to go!";
        HPCheck = CheckStatus;
    }

    ///<summary>Print to the console the health of this player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    ///<summary>Damages this player, subtracting its HP.</summary>
    public void TakeDamage(float damage)
    {
        damage = damage >= 0 ? damage : 0;
        Console.WriteLine($"{this.name} takes {damage} damage!");
        ValidateHP(this.hp - damage);
    }

    ///<summary>Heals this player, restoring its HP.</summary>
    public void HealDamage(float heal)
    {
        heal = heal >= 0 ? heal : 0;
        Console.WriteLine($"{this.name} heals {heal} HP!");
        ValidateHP(this.hp + heal);
    }

    ///<summary>Set the value of the hit points after healing or taking damage.</summary>
    public void ValidateHP(float newHP)
    {
        if (newHP < 0)
            this.hp = 0;
        else if (newHP > this.maxHp)
            this.hp = maxHp;
        else
            this.hp = newHP;
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    ///<summary>Modifies the damage/healing taken, based on a modifier</summary>
    public float ApplyModifier(float newHP, Modifier modifier)
    {
        switch ((int)modifier)
        {
            case 0:
                newHP *= 0.5f;
                break;
            case 1:
                newHP *= 1f;
                break;
            case 2:
                newHP *= 1.5f;
                break;
        }
        return newHP;
    }

    // Prints this instance status regarding its remaining HP.
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            Console.WriteLine($"{name} is in perfect health!");
        else if (e.currentHp < this.maxHp && this.hp >= this.maxHp / 2)
            Console.WriteLine($"{name} is doing well!");
        else if (e.currentHp < this.maxHp / 2 && this.hp >= this.maxHp / 4)
            Console.WriteLine($"{name} isn't doing too great...");
        else if (e.currentHp < this.maxHp / 4 && this.hp > 0)
            Console.WriteLine($"{name} need help!");
        else
            Console.WriteLine($"{name} is knocked out!");
    }
}
