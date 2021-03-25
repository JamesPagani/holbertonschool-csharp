using System;

///<summary>A player.</summary>
public class Player
{
    // Player name
    private string name {get; set;}

    // Maximum hit points
    private float maxHP {get; set;}

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
}
