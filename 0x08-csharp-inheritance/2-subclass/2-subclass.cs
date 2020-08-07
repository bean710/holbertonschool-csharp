using System;

/// <summary>
/// Class for methods on objects
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if a class is a subclass of another class
    /// </summary>
    /// <param name="derivedType">The type to check if it is a subclass</param>
    /// <param name="baseType">The type to check if derrivedType is a subclass of it</param>
    /// <returns>True if subclass, otherwise false.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}