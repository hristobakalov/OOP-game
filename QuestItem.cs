namespace OOP_Teamwork___Game
{
    public class QuestItem : Item, IItem
    {
        // this needs quest implementation and stuff
        #region Fields

        //private Quest quest;

        #endregion

        #region Constructors

        public QuestItem(string name)
            : base(name)
        {
            this.ItemType = ItemType.QuestItem;
        }

        #endregion
    }
}