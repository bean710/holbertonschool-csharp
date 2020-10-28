/// <summary>
/// A delegate for methods which deal with health
/// </summary>
/// <param name="v">The value to be affected by</param>
public delegate void CalculateHealth(float v);

partial class Player
{
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
}