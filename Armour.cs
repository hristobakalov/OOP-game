namespace OOP_Teamwork___Game
{
    using System;

    public class Armour : Item, IWearable, IItem
    {
        #region Fields

        private int requiredLevel;
        private int hpIncrease;
        private readonly ArmourPiece armourPiece;

        #endregion

        #region Constructors

        public Armour(string name, int requiredLevel, ArmourPiece armourPiece, int hpIncrease)
            : base(name)
        {
            this.RequiredLevel = requiredLevel;
            this.armourPiece = armourPiece;
            this.HpIncrease = hpIncrease;
            this.ItemType = ItemType.Armour;
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
                if (value < 2)
                {
                    throw new ArgumentException("Required level must be above 1.");
                }

                this.requiredLevel = value;
            }
        }

        public int HpIncrease
        {
            get
            {
                return this.hpIncrease;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HP increase cannot be less than 0.");
                }

                this.hpIncrease = value;
            }
        }

        public ArmourPiece ArmourPiece
        {
            get { return this.armourPiece; }
        }

        #endregion
    }
}
