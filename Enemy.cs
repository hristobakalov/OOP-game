namespace OOP_Teamwork___Game
{
    using System.Collections.Generic;

    public class Enemy : Fighter//, IDrawable, IMoveable
    {
        // Not finished
        # region Automated Properties

        public int ExperienceDrop { get; private set; }
        public int GloryPointsDrop { get; private set; }

        # endregion

        # region Constructors

        public Enemy(string name, int health, List<Ability> abilities, int experienceDrop = 1, int gloryPointsDrop = 1)
            : base(name, health, abilities)
        {
            this.ExperienceDrop = experienceDrop;
            this.GloryPointsDrop = gloryPointsDrop;
        }

        # endregion
    }
}