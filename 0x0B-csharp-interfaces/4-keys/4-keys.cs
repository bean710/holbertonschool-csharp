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
/// A class for door mechanics
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor for a Door
    /// </summary>
    /// <param name="name">Optional: Name of the door, defaults to "Door"</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interact with the door, will give the user output
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

/// <summary>
/// A class for decoration mechanics
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// How much durability the decoration has
    /// </summary>
    /// <value>gets/sets the durability property of the decoration</value>
    public int durability { get; set; }

    /// <summary>
    /// Whether or not the decoration is a quest item
    /// </summary>
    /// <value>gets/sets the quest item property of the decoration</value>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// Constructor for a decoration
    /// </summary>
    /// <param name="name">Optional: The name for the decoration to have. Defaults to "Decoration"</param>
    /// <param name="durability">Optional: How much durability the decoration should have. Defaults to 1</param>
    /// <param name="isQuestItem">Optional: Whether or not the decoration is a quest item. Defaults to false</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interact with the decoration. Provides the user with output
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
            return;
        }

        if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
            return;
        }

        Console.WriteLine($"You look at the {name}. Not much to see here.");
    }
    
    /// <summary>
    /// Reduce the durability of the decoration
    /// </summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// A class for a key object
/// </summary>
class Key : Base, ICollectable
{
    /// <summary>
    /// Whether or not the Key has been collected
    /// </summary>
    /// <value>gets/sets the isCollected property of the Key</value>
    public bool isCollected { get; set; }

    /// <summary>
    /// Key constructor
    /// </summary>
    /// <param name="name">Optional: The name of the key, "Key" by default</param>
    /// <param name="isCollected">Optional: Whether or not the key is collected, false by default</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collect the key
    /// </summary>
    public void Collect()
    {
        if (isCollected)
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
        else
        {
            isCollected = true;
            Console.WriteLine($"You picked up the {name}.");
        }
    }
}