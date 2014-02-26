using System.Collections.Generic;
using System.IO;
using System;
namespace OOP_Teamwork___Game
{
    public abstract class Map : IDrawable
    {
        public List<string> Content { get; set; }

        public Map()
        {
        }

        public Map(List<string> content)
        {
            this.Content = content;
        }

        // Still needs implementation of the graffics
        //I think maps should be hold as a single string and to avoid hard code should be hold in a .txt file.
        //Then read by a StreamReader and print in in cursor position (0 , 0)

        public void Print()
        {
            Console.SetCursorPosition(0, 0);

            foreach (var row in this.Content)
            {
                foreach (var item in row)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
            }
        }

        public void Print(Point point, List<string> objectToDraw)
        {
            Console.SetCursorPosition(point.CoordY, point.CoordX);

            foreach (var row in objectToDraw)
            {
                foreach (var item in row)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
            }
        }
    }
}