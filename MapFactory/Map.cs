using System.IO;
namespace OOP_Teamwork___Game
{
    public abstract class Map 
    {
        public string Content { get; set; }

        public Map(string content)
        {
            this.Content = content;
        }
        // Still needs implementation of the graffics
        //I think maps should be hold as a single string and to avoid hard code should be hold in a .txt file.
        //Then read by a StreamReader and print in in cursor position (0 , 0)
    }
}