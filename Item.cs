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
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name cannot be less that 3 characters.");
                }
            }
        }

        #endregion
    }
}