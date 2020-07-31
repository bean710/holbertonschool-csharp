using System;

namespace Enemies
{
    /// <summary>
    /// A simple Zombie class
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// The health of the Zombie
        /// </summary>
        private int health;

        /// <summary>
        /// Constructor for the Zombie
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Constructor for the Zombie
        /// </summary>
        /// <param name="value">Health</param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            this.health = value;
        }

        /// <summary>
        /// Gets the Zombie's health
        /// </summary>
        /// <returns>The health of the Zombie</returns>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
