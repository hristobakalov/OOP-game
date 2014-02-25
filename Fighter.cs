namespace OOP_Teamwork___Game
{
    using System;
    using System.Collections.Generic;

    // If someone comes up with a better name, change it
    public abstract class Fighter : InteractiveEntity, IInteractive
    {
        // Not finished
        #region Fields

        private int maxHealth;
        private int currentHealth;
        private List<Ability> abilities;

        #endregion

        #region Constructors

        public Fighter(Point coordinates, string name, int maxHealth, List<Ability> abilities)
            : base(coordinates, name)
        {
            this.MaxHealth = maxHealth;
            this.Abilities = abilities;
        }

        #endregion

        #region Properties

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