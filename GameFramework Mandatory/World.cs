using System;
using System.Collections.Generic;

namespace GameFramework_Mandatory
{
    public class World
    {

        public int SizeX { get; set; }
        public int SizeY { get; set; }

        public World(int x, int y)
        {
            SizeX = x;
            SizeY = y;
        }

        public List<WorldObject> Objects = new List<WorldObject>();
        public List<PlayerCharacter> Characters = new List<PlayerCharacter>();
    }
}
