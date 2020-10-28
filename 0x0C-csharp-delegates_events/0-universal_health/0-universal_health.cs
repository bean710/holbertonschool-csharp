using System;

/// <summary>
/// Class containing Player details and functions
/// </summary>
class Player
{
    /// <summary>
    /// The name of the player
    /// </summary>
    private string name { get; set; }

    private float _maxHp;
    /// <summary>
    /// The maximum HP of the player
    /// </summary>
    private float maxHp
    {
        get { return _maxHp; }
        set
        {
            if (value < 0f)
            {
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
                _maxHp = 100f;
            }
            else
            {
                _maxHp = value;
            }
        }
    }

    /// <summary>
    /// The current HP of the player
    /// </summary>
    private float hp { get; set; }

    /// <summary>
    /// Player constructor
    /// </summary>
    /// <param name="name">The name to be given to the player, "Player" by default</param>
    /// <param name="maxHp">The maximum HP the player can have, 100 by default</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        this.maxHp = maxHp;
        this.hp = this.maxHp;
    }

    /// <summary>
    /// Print out the player's health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}