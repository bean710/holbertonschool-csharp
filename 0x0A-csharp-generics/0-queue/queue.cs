using System;

/// <summary>
/// A Queue class
/// </summary>
/// <typeparam name="T">The type the Queue contains</typeparam>
class Queue<T>
{
    /// <summary>
    /// Get the type that the Queue contains
    /// </summary>
    /// <returns>The type of the Queue</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}