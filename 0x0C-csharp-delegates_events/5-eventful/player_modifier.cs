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

partial class Player
{
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