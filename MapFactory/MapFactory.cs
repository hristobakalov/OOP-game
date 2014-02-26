using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Teamwork___Game
{
    internal class MapFactory
    {

        private const string firstLevelMapPath = "FirstLevelMap.txt"; 

        public Map GenerateMap(Maptypes mapType)
        {
            switch (mapType)
            {
                case Maptypes.FirstLevelMap:
                    {
                        StreamReader sr = new StreamReader(firstLevelMapPath);
                        string content = sr.ReadToEnd();
                        return new FirstLevelMap(content);
                    }
                case Maptypes.SecondLevelMap:
                    return new SecondLevelMap("Not implemented");
                case Maptypes.ThirdLevelMap:
                    return new ThirdLevelMap("Not implemented");
                case Maptypes.DuelMap:
                    return new DuelMap("Not implemented");
                default:
                    return null;
            }
        }

    }
}
