using System;

/// <summary>
/// Modifier names for Players
/// </summary>
public enum Modifier
{
    /// <summary> Decreases the value </summary>
    Weak,
    /// <summary> Makes no modifications to the value </summary>
    Base,
    /// <summary> Increases the value </summary>
    Strong
}

/// <summary>
/// Calculates a new value based on a specified modifier
/// </summary>
/// <param name="baseValue">The value to potentially modify</param>
/// <param name="modifier">The modifier to apply to the baseValue</param>
/// <returns>The result of the baseValue being modified by modifier</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// A delegate for methods which deal with health
/// </summary>
/// <param name="v">The value to be affected by</param>
public delegate void CalculateHealth(float v);

/// <summary>
/// Class containing Player details and functions
/// </summary>
partial class Player
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
    /// The current status of the player
    /// </summary>
    private string status { get; set; }

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
        this.status = $"{this.name} is ready to go!";

        this.HPCheck += this.CheckStatus;
    }

    /// <summary>
    /// Print out the player's health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Reduce the health of the player
    /// </summary>
    /// <param name="damage">The amount to reduce the health by</param>
    public void TakeDamage(float damage)
    {
        damage = Math.Max(damage, 0);
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(this.hp - damage);
    }

    /// <summary>
    /// Increase the health of the player
    /// </summary>
    /// <param name="heal">The amount to increase the health by</param>
    public void HealDamage(float heal)
    {
        heal = Math.Max(heal, 0);
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(this.hp + heal);
    }

    /// <summary>
    /// Validates that the requested new health of the player is between 0 and the Player's maxHp
    /// </summary>
    /// <param name="newHp">The new hp the set the Player's hp to</param>
    public void ValidateHP(float newHp)
    {
        this.hp = Math.Max(0, Math.Min(this.maxHp, newHp));

        OnCheckStatus(new CurrentHPArgs(this.hp));
    }

    /// <summary>
    /// Gets a new value based on the original baseValue as affected by the modifier
    /// </summary>
    /// <param name="baseValue">The value to apply a Modifier to</param>
    /// <param name="modifier">The Modifier to apply to the baseValue</param>
    /// <returns>The new value after being modified</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue / 2f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
    }
}