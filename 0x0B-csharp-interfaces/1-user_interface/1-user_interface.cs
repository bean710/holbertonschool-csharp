using System;

/// <summary>
/// A base class for all of the game objects
/// </summary>
abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// Defines the properties of an interactive object
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// Defines the properties of a breakable object
/// </summary>
interface IBreakable
{
    int durability { get; set; }
}

/// <summary>
/// Defines the properties of a collectable object
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// A test object for inheriting interfaces
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }
    
    public void Interact()
    {

    }

    public void Collect()
    {

    }
}