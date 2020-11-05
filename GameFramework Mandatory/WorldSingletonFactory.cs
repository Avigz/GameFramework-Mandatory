using GameFramework_Mandatory.interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GameFramework_Mandatory
{
    public class WorldSingletonFactory
    {
        private static WorldSingletonFactory _instance;

        public Position WorldSize;

        private WorldSingletonFactory(Position maxvalues)
        {
            WorldSize = maxvalues;
        }

        public List<IWorldObject> Objects = new List<IWorldObject>();
        public List<PlayerCharacter> Characters = new List<PlayerCharacter>();
        public void AddCharacter(PlayerCharacter c)
        {
            if(c.CharacterPos.X <= WorldSize.X && c.CharacterPos.Y <= WorldSize.Y)
            {
                Characters.Add(c);
            }
        }

        public static WorldSingletonFactory CreateInstance(Position maxvalues = null)
        {
            if (_instance == null)
            {
                if (maxvalues != null)
                {
                    _instance = new WorldSingletonFactory(maxvalues);
                }
                else
                {
                    _instance = new WorldSingletonFactory(new Position(10,20));
                }
                
            }

            return _instance;
        }
    }
}
