using System;
using System.Collections.Generic;

namespace GameFramework_Mandatory
{
    public class WorldSingleton
    {
        private static WorldSingleton _instance;

        public Position WorldSize;

        protected WorldSingleton()
        {

        }

        public WorldSingleton(Position maxvalues)
        {
            WorldSize = maxvalues;
        }

        public List<WorldObject> Objects = new List<WorldObject>();
        public List<PlayerCharacter> Characters = new List<PlayerCharacter>();

        public static WorldSingleton Instance()
        {

            if (_instance == null)
            {
                _instance = new WorldSingleton();
            }

            return _instance;
        }
    }
}
