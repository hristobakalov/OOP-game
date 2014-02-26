namespace OOP_Teamwork___Game
{
    using System;

    public abstract class InteractiveEntity : IInteractive
    {
        #region Fields

        private Point coordinates;
        private string name;
        private int level = 1;

        #endregion

        #region Constructors

        public InteractiveEntity(Point coordinates, string name)
        {
            this.Coordinates = coordinates;
            this.Name = name;
        }

        #endregion

        #region Properties

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
                    throw new ArgumentOutOfRangeException("These coordinates aren't valid!");
                }

                this.coordinates = value;
            }
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

                foreach (char ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        throw new InvalidNameException("Name must contain only letters.");
                    }
                }

                this.name = value;
            }
        }

        public int Level
        {
            get { return this.level; }
            protected set { this.level = value; }
        }

        #endregion
    }
}