namespace OOP_Teamwork___Game
{
    using System;

    public class Weapon : Item, IWearable, IItem
    {
        #region Fields

        private int requiredLevel;
        private readonly WeaponType weaponType;
        private int damage;
        private double attackSpeed;

        #endregion

        #region Constructors

        public Weapon(string name, int requiredLevel, WeaponType weaponType, int damage, double attackSpeed)
            : base(name)
        {
            this.RequiredLevel = requiredLevel;
            this.weaponType = weaponType;
            this.Damage = damage;
            this.AttackSpeed = attackSpeed;
            this.ItemType = ItemType.Weapon;
        }
        #endregion

        #region Properties

        public int RequiredLevel
        {
            get 
            { 
                return this.requiredLevel; 
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Required level must be above 0.");
                }

                this.requiredLevel = value;
            }
        }

        public WeaponType WeaponType
        {
            get { return this.weaponType; }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Damage must be above 0.");
                }

                this.damage = value;
            }
        }

        public double AttackSpeed
        {
            get
            {
                return this.attackSpeed;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Attack speed cannot be less than 1.");
                }

                this.attackSpeed = value;
            }
        }

        #endregion
    }
}