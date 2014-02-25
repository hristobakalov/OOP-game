namespace OOP_Teamwork___Game
{
    using System.Collections.Generic;

    public class Enemy : Fighter, IInteractive//, IDrawable, IMoveable
    {
        // Not finished
        # region Automated Properties

        public int ExperienceDrop { get; private set; }
        public int GloryPointsDrop { get; private set; }

        # endregion

        # region Constructors

        public Enemy(Point coordinates, string name, int maxHealth, List<Ability> abilities, int experienceDrop = 1, int gloryPointsDrop = 1)
            : base(coordinates, name, maxHealth, abilities)
        {
            this.ExperienceDrop = experienceDrop;
            this.GloryPointsDrop = gloryPointsDrop;
        }

        # endregion
    }
}