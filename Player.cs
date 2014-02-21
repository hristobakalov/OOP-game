namespace OOP_Teamwork___Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Player : Fighter//, IDrawable, IMoveable
    {
        // Not finished
        #region Fields

        private int mana = 150;
        private ulong experience = 0;
        private ulong experienceForNextLvl = 20000;
        private int gloryPoints = 0; // Currency for items, why a virus would need money...

        #endregion

        #region Constructors

        // Health given in the constructor in case there are difficulty options
        public Player(string name, int health, List<Ability> abilities)
            : base(name, health, abilities)
        {
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

            private set
            {
                if (value >= this.experienceForNextLvl)
                {
                    this.Level++;
                    this.experience = value - this.experienceForNextLvl; // Move the bonus experience
                    this.experienceForNextLvl += (ulong)(this.experienceForNextLvl * 0.75); // The next level will require 175%   

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
    }
}
