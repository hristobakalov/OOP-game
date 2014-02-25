namespace OOP_Teamwork___Game
{
    using System;

    public class Ability
    {
        // Not finished, must add passive effect changers and some methods for that
        #region Fields

        private readonly int requiredLevel;
        private readonly AbilityType abilityType;
        private int damage;
        private int abilityLevel = 1;

        #endregion

        #region Constructors

        public Ability(int damage, int requiredLevel, AbilityType abilityType)
        {
            this.Damage = damage;
            this.requiredLevel = requiredLevel;
            this.abilityType = abilityType;
        }

        #endregion

        #region Properties

        public int Damage
        {
            get 
            {
                return this.damage; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Damage must be more than 0.");
                }

                this.damage = value;
            }
        }

        public int AbilityLevel
        {
            get { return this.abilityLevel; }
            set { this.abilityLevel = value; }
        }

        public int RequiredLevel
        {
            get { return this.requiredLevel; }
        }

        public AbilityType AbilityType
        {
            get { return this.abilityType; }
        }

        #endregion
    }
}