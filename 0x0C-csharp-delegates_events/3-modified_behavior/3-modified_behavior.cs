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

///<summary>A player.</summary>
public class Player
{
    // Player name
    private string name;

    // Maximum hit points
    private float maxHp;

    // Current hit points
    private float hp;

    ///<summary>Initiate a new player instance.</summary>
    public Player(string name = "Player", float maxHp = 100f){
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
        ValidateHP(this.hp - damage);
        Console.WriteLine($"{this.name} takes {damage} damage!");
    }

    ///<summary>Heals this player, restoring its HP.</summary>
    public void HealDamage(float heal)
    {
        heal = heal >= 0 ? heal : 0;
        ValidateHP(this.hp + heal);
        Console.WriteLine($"{this.name} heals {heal} HP!");

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
}
