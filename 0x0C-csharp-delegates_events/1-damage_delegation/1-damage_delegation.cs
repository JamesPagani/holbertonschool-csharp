using System;

///<summary>Performs all necesary hit points calculations.</summary>
public delegate void CalculateHealth(float hp);

///<summary>A player.</summary>
public class Player
{
    // Player name
    private string name {get; set;}

    // Maximum hit points
    private float maxHP{get; set;}

    // Current hit points
    private float hp {get; set;}

    ///<summary>Initiate a new player instance.</summary>
    public Player(string name = "Player", float maxHP = 100f){
        if (maxHP <= 0)
        {
            this.maxHP = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHP = maxHP;
        }
        this.hp = this.maxHP;
        this.name = name;
    }

    ///<summary>Print to the console the health of this player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHP} health");
    }

    ///<summary>Damages this player, subtracting its HP.</summary>
    public void TakeDamage(float damage)
    {
        damage = damage >= 0 ? damage : 0;
        Console.WriteLine($"{this.name} takes {damage} damage!");
    }

    ///<summary>Heals this player, restoring its HP.</summary>
    public void HealDamage(float heal)
    {
        heal = heal >= 0 ? heal : 0;
        Console.WriteLine($"{this.name} heals {heal} HP!");
    }
}
