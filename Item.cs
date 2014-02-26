namespace OOP_Teamwork___Game
{
    using System;

    public abstract class Item : IItem
    {
        #region Fields

        private ItemType itemType;
        private readonly string name;

        #endregion

        #region Constructors

        public Item(string name)
        {
            this.name = name;
        }

        #endregion

        #region Properties

        public ItemType ItemType
        {
            get { return this.itemType; }
            protected set { this.itemType = value; }
        }

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
                    throw new InvalidNameException("Name cannot be less than 3 and more than 15 characters.");
                }
            }
        }

        #endregion
    }
}