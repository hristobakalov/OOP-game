namespace OOP_Teamwork___Game
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class MapFactory
    {
        private const string FirstLevelMapPath = "FirstLevelMap.txt";
        private const string SecondLevelMapPath = "FirstLevelMap.txt"; //TODO : Create paths for each map
        private const string ThirdLevelMapPath = "FirstLevelMap.txt";
        private const string DuelMapPath = "FirstLevelMap.txt";

        public Map GenerateMap(Maptypes mapType)
        {
            switch (mapType)
            {
                case Maptypes.FirstLevelMap:
                    {
                        StreamReader sr = new StreamReader(FirstLevelMapPath);
                        string line = sr.ReadLine();
                        List<string> content = new List<string>();
                        while (line != null)
                        {
                            content.Add(line);
                            line = sr.ReadLine();
                        }

                        return new FirstLevelMap(content);
                    }
                case Maptypes.SecondLevelMap:
                    {
                        StreamReader sr = new StreamReader(FirstLevelMapPath);
                        string line = sr.ReadLine();
                        List<string> content = new List<string>();
                        while (line != null)
                        {
                            content.Add(line);
                            line = sr.ReadLine();
                        }

                        return new SecondLevelMap(content);
                    }
                case Maptypes.ThirdLevelMap:
                    {
                        StreamReader sr = new StreamReader(FirstLevelMapPath);
                        string line = sr.ReadLine();
                        List<string> content = new List<string>();
                        while (line != null)
                        {
                            content.Add(line);
                            line = sr.ReadLine();
                        }

                        return new ThirdLevelMap(content);
                    }
                case Maptypes.DuelMap:
                    {
                        StreamReader sr = new StreamReader(FirstLevelMapPath);
                        string line = sr.ReadLine();
                        List<string> content = new List<string>();
                        while (line != null)
                        {
                            content.Add(line);
                            line = sr.ReadLine();
                        }

                        return new DuelMap(content);
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}