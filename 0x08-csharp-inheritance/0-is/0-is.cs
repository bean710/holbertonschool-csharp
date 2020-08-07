using System;

/// <summary>
/// Class to contain methods for objects
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if an object is an int
    /// </summary>
    /// <param name="obj">The object to check</param>
    /// <returns>True if the object is an int, otherwise false.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj.GetType() == typeof(int));
    }
}