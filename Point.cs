namespace OOP_Teamwork___Game
{
    public struct Point
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public Point(int coordX, int coordY)
            : this()
        {
            this.CoordX = coordX;
            this.CoordY = coordY;
        }
    }
}
