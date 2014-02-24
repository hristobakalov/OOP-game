namespace OOP_Teamwork___Game
{
    using System;
    using System.Collections.Generic;

    // If someone comes up with a better name, change it
    public abstract class Fighter
    {
        // Not finished
        #region Fields

        private Point coordinates;
        private string name;
        private int maxHealth;
        private int currentHealth;
        private int level = 1;
        private List<Ability> abilities;

        #endregion

        #region Constructors

        public Fighter(string name, int maxHealth, List<Ability> abilities, Point coordinates)
        {
            this.Name = name;
            this.MaxHealth = maxHealth;
            this.Abilities = abilities;
            this.Coordinates = coordinates;
        }

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Name cannot be less than 3 and more than 15 characters.");
                }

                foreach (char ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        throw new ArgumentException("Name must contain only letters.");
                    }
                }

                this.name = value;
            }
        }

        public int MaxHealth
        {
            get
            {
                return this.maxHealth;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot create fighter with less than 1 health points.");
                }

                this.maxHealth = value;
            }
        }

        public int CurrentHealth
        {
            get
            {
                return this.currentHealth;
            }
            set
            {
                if (value < 0)
                {
                    this.currentHealth = 0;
                }
                else if (value > this.MaxHealth)
                {
                    this.currentHealth = this.MaxHealth;
                }
                else
                {
                    this.currentHealth = value;
                }
            }
        }

        public int Level
        {
            get { return this.level; }
            protected set { this.level = value; }
        }

        public List<Ability> Abilities
        {
            get
            {
                return new List<Ability>(this.abilities);
            }

            private set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("List of abilites cannot be null or empty.");
                }

                this.abilities = value;
            }
        }

        public Point Coordinates 
        {
            get
            {
                return this.coordinates;
            }
            set 
            {
                if ((value.CoordX < 0 || value.CoordX > Console.WindowWidth) || (value.CoordY < 0 || value.CoordY > Console.WindowHeight))
                {
                    throw new ArgumentOutOfRangeException("This coordinates aren't valid!");
                }
                this.coordinates = value;
            }
        }

        #endregion

        #region Methods

        public void AddAbility(Ability ability)
        {
            if (ability == null)
            {
                throw new ArgumentException("Cannot add null ability.");
            }

            this.abilities.Add(ability);
        }

        #endregion
    }
}