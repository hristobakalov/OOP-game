namespace OOP_Teamwork___Game
{
    public class Ability
    {
        // Not finished
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
            get { return this.damage; }
            set { this.damage = value; }
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