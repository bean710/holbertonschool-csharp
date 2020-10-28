using System;

/// <summary>
/// Arguments for a HPCheck event
/// </summary>
class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// The current hp of the event sender Player
    /// </summary>
    public float currentHp { get; }

    /// <summary>
    /// Constructor for the HPCheck event args
    /// </summary>
    /// <param name="newHp">The new HP of the Player</param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}

partial class Player
{
    /// <summary>
    /// Handles events on HP changes
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Helper function for raising events
    /// </summary>
    /// <param name="e">Event parameters</param>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        EventHandler<CurrentHPArgs> raiseEvent = HPCheck;

        if (raiseEvent == null)
            return;

        if (e.currentHp <= this.maxHp / 4f)
            raiseEvent += HPValueWarning;

        raiseEvent(this, e);
    }

    /// <summary>
    /// Checks the status of the player's HP on event
    /// </summary>
    /// <param name="sender">The sender of the event</param>
    /// <param name="e">The event data</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = $"{name} is in perfect health!";
        else if (e.currentHp >= this.maxHp / 2f)
            this.status = $"{name} is doing well!";
        else if (e.currentHp >= this.maxHp / 4f)
            this.status = $"{name} isn't doing too great...";
        else if (e.currentHp > 0)
            this.status = $"{name} needs help!";
        else
            this.status = $"{name} is knocked out!";

        Console.WriteLine(this.status);
    }

    /// <summary>
    /// Handles an HPCheck when the health is low
    /// </summary>
    /// <param name="sender">The sender of the event</param>
    /// <param name="e">Event data</param>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached 0!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Health is low!");
        }

        Console.ResetColor();
    }
}