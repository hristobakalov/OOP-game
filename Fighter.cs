namespace OOP_Teamwork___Game
{
    using System;
    using System.Collections.Generic;

    // If someone comes up with a better name, change it
    public abstract class Fighter
    {
        // Not finished
        #region Fields

        private string name;
        private int health;
        private int level = 1;
        private List<Ability> abilities;

        #endregion

        #region Constructors

        public Fighter(string name, int health, List<Ability> abilities)
        {
            this.Name = name;
            this.Health = health;
            this.Abilities = abilities;
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

        public int Health
        {
            get
            {
                return this.health;
            }

            private set
            {
                if (value < 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.health = value;
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