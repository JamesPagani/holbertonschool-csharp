using System;

namespace Enemies
{
    /// <summary>Represents a zombie enemy.</summary>
    class Zombie
    {
        // The health/hit points of a Zombie.
        private int health;
        // The name of a Zombie.
        private string name = "(No name)";

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        /// <remark>This version sets the health of the zombie to 0</remark>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        /// <remark>This version sets the health of the zombie to an user-specified amount</remark>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }

        /// <summary>Gets the health of the zombie.</summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get {return name;}
            set {name = value;}
        }
    }
}
