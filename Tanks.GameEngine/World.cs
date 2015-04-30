using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tanks.GameEngine
{

    public class World
    {
        public static char[,] MapArray { get; set; }
        public World()
        {
            MapArray = new char[20, 20];
            int index = 0;
            char[] mapData = null;
<<<<<<< HEAD
            string path = @"../../../Tanks.GameEngine/Maps/map_1.txt";  // need use absolute path
                                                                        //Tanks.GameEngine/Maps/map_1.txt" this value => config file
=======
            string path = @"../../../Tanks.GameEngine/Maps/map_1.txt";
>>>>>>> ac1aa47847c5668fb2e809b3a3ae687c984f7a88
            using (StreamReader reader = new StreamReader(path))
            {
                string mapInfo = reader.ReadToEnd();
                mapData = mapInfo.ToCharArray();
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    MapArray[i, j] = mapData[index];
                    ++index;
                }
            }
        }
    }
}

