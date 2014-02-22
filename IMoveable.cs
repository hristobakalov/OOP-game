namespace OOP_Teamwork___Game
{
    using System.Collections.Generic;

    public interface IMoveable
    {
        void Move(Point currentPoint, Point newPoint, List<string> objectToDraw);
    }
}