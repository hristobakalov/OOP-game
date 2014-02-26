namespace OOP_Teamwork___Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Player : Fighter, IInteractive//, IDrawable, IMoveable
    {
        // Not finished
        #region Fields  
   
        public event EventHandler LeveledUp;
        private int mana = 150;
        private ulong experience = 0;
        private ulong experienceForNextLvl = 20000;
        private int gloryPoints = 0; // Currency for items, why a virus would need money...
        private const char playerSymbol = '@'; //just for test

        #endregion

        #region Constructors

        // Health given in the constructor in case there are difficulty options
        public Player(Point coordinates, string name, int maxHealth, List<Ability> abilities)
            : base(coordinates, name, maxHealth, abilities)
        {
            this.LeveledUp += (s, e) =>
                {
                    Console.SetCursorPosition(122, 0);
                    Console.Write("Level: {0}", this.Level);
                };
        }

        #endregion

        #region Properties

        public int Mana
        {
            get
            {
                return this.mana;
            }

            private set
            {
                if (value < 0)
                {
                    this.mana = 0;
                }
                else
                {
                    this.mana = value;
                }
            }
        }

        public ulong Experience
        {
            get
            {
                return this.experience;
            }

            set
            {
                if (value >= this.experienceForNextLvl)
                {
                    this.Level++;
                    this.experience = value - this.experienceForNextLvl; // Move the bonus experience
                    this.experienceForNextLvl += (ulong)(this.experienceForNextLvl * 0.75); // The next level will require 175%   
                    LeveledUp(this, new EventArgs()); // Just an event usage

                    foreach (var ability in this.Abilities)
                    {
                        ability.AbilityLevel++;
                        ability.Damage += (int)(ability.Damage * 0.3); // Increasethe damage by 30%
                    }
                }
                else
                {
                    this.experience = value;
                }
            }
        }

        public int GloryPoints
        {
            // Can assign negative glory points
            get { return this.gloryPoints; }
            private set { this.gloryPoints = value; }
        }

        #endregion 

        #region Methods

        public void MovePlayer(int rowChange, int colChange)
        {
            int newRowAfterMove = Coordinates.CoordY + rowChange;
            int newColAfterMove = Coordinates.CoordX + colChange;
            if (newRowAfterMove >= 0 && newColAfterMove >= 0 && newRowAfterMove < Console.WindowHeight && newColAfterMove < Console.WindowWidth)
            {
                Draw.ConsoleWrite(Coordinates.CoordX, Coordinates.CoordY, " ");
                Coordinates = new Point(newColAfterMove, newRowAfterMove);

                Draw.ConsoleWrite(Coordinates.CoordX, Coordinates.CoordY, playerSymbol.ToString());
            }
        }

        #endregion
    }
}
