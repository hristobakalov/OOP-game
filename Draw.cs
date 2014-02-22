namespace OOP_Teamwork___Game
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Draw : IDrawable, IErasable, IMoveable
    {
        // TODO : Implement exeption handler
        // TODO : StyleCop

        private const char Interval = ' ';

        #region Methods

        public void Print(Point point, List<string> objectToDraw)
        {
            for (int i = 0; i < objectToDraw.Count; i++)
            {
                Console.SetCursorPosition(point.CoordX, point.CoordY);
                Console.WriteLine(objectToDraw[i]);
                point.CoordY++;
            }
        }

        public void Move(Point currentPoint, Point newPoint, List<string> objectToDraw)
        {
            this.Erase(currentPoint, objectToDraw);
            this.Print(newPoint, objectToDraw);
        }

        public void Erase(Point currentPoint, List<string> objectToErase)
        {
            List<string> toErase = new List<string>();

            for (int i = 0; i < objectToErase.Count; i++)
            {
               toErase.Add(new string(Interval, objectToErase[i].Length));
            }

            for (int i = 0; i < toErase.Count; i++)
            {
                Console.SetCursorPosition(currentPoint.CoordX, currentPoint.CoordY);
                Console.WriteLine(toErase[i]);
                currentPoint.CoordY++;
            }
        }

        #endregion

    }
}
