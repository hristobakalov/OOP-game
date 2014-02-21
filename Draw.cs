namespace OOP_Teamwork___Game
{
    using System;
    using System.Text;

    public class Draw : IDrawable, IErasable, IMoveable
    {
        // TODO : Implement exeption handler
        // TODO : StyleCop

        private const char Interval = ' ';

        #region Methods

        public void Print(Point point, string[] objectToDraw)
        {
            for (int i = 0; i < objectToDraw.Length; i++)
            {
                Console.SetCursorPosition(point.CoordX, point.CoordY);
                Console.WriteLine(objectToDraw[i]);
                point.CoordY++;
            }
        }

        public void Move(Point currentPoint, Point newPoint, string[] objectToDraw)
        {
            this.Erase(currentPoint, objectToDraw);
            this.Print(newPoint, objectToDraw);
        }

        public void Erase(Point currentPoint, string[] objectToErase)
        {
            string[] toErase = new string[objectToErase.Length];

            for (int i = 0; i < objectToErase.Length; i++)
            {
                toErase[i] = new string(Interval, objectToErase[i].Length);
            }

            for (int i = 0; i < toErase.Length; i++)
            {
                Console.SetCursorPosition(currentPoint.CoordX, currentPoint.CoordY);
                Console.WriteLine(toErase[i]);
                currentPoint.CoordY++;
            }
        }

        #endregion
    }
}
