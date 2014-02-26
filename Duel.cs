namespace OOP_Teamwork___Game
{
    using System;
    
    public class Duel
    { 
        // TODO: Drawing of the landscape and overall situation of the duel components
        #region Fields

        private Fighter fighter1;
        private Fighter fighter2;

        #endregion 

        #region Constructors

        public Duel(Fighter fighter1, Fighter fighter2)
        {
            this.Fighter1 = fighter1;
            this.Fighter2 = fighter2;
        }

        #endregion

        #region Properties

        public Fighter Fighter1
        {
            get
            {
                return this.fighter1;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The fighter cannot be null.");
                }

                this.fighter1 = value;
            }
        }

        public Fighter Fighter2
        {
            get
            {
                return this.fighter2;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The fighter cannot be null.");
                }

                this.fighter2 = value;
            }
        }

        #endregion

        #region Methods

        public Fighter RunDuel()
        {
            Random randomGenerator = new Random();

            int firstToAttack = randomGenerator.Next(1, 3);
            Fighter attacker = this.Fighter1;
            Fighter attacked = this.Fighter2;

            if (firstToAttack == 2)
            {
                attacker = this.Fighter2;
                attacked = this.Fighter1;
            }

            do
            {
                Ability ability = this.ChoseAbility(attacker.Abilities); // Chose Ability method must be implemented, again graphics matter

                if (ability.AbilityType == AbilityType.Offensive)
                {
                    attacked.CurrentHealth -= ability.Damage;
                }
                else if (ability.AbilityType == AbilityType.Defensive)
                {
                    attacker.CurrentHealth += ability.Damage;
                }
                //else if (ability.AbilityType == AbilityType.Passive) I need to implement the passive effect variables and stuff
                //{
                    
                //}

                // TODO: Here we must draw the attack and like messages, but idk the coordinated and how it's gonna look

                // Here we change the attacked and the attacker
                if (attacker == this.Fighter1)
                {
                    attacker = this.Fighter2;
                    attacked = this.Fighter1;
                }
                else
                {
                    attacker = this.Fighter1;
                    attacked = this.Fighter2;
                }

            } while (this.Fighter1.CurrentHealth != 0 || this.Fighter2.CurrentHealth != 0);

            if (this.Fighter1.CurrentHealth == 0)
            {
                return this.Fighter2;
            }
            else
            {
                return this.Fighter1;
            }
        }

        private Ability ChoseAbility(System.Collections.Generic.List<Ability> list)
        {
            // IDK if this is supposed to be in this class
            throw new NotImplementedException();
        }

        #endregion
    }
}