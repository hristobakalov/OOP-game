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

        public Enemy(string name, int maxHealth, List<Ability> abilities, Point coordinates, int experienceDrop = 1, int gloryPointsDrop = 1)
            : base(name, maxHealth, abilities, coordinates)
        {
            this.ExperienceDrop = experienceDrop;
            this.GloryPointsDrop = gloryPointsDrop;
        }

        # endregion
    }
}