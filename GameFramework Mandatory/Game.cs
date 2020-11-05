using GameFramework_Mandatory.interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace GameFramework_Mandatory
{
    public class Game
    {
        public Game(WorldSingletonFactory world)
        {

            _gameWorld = world;

        }
        private WorldSingletonFactory _gameWorld;

        public void GetFights()
        {
            foreach (var v in _gameWorld.Characters)
            {
                foreach(var p in _gameWorld.Characters)
                {
                    if (v.NearbyCharacter(p) && v != p)
                    {
                        FightSim.Fight(p, v);
                    }
                }
            }
        }

        public void GetWorldObjects()
        {
            foreach(var v in _gameWorld.Characters)
            {
                foreach(var p in _gameWorld.Objects)
                {
                    v.GetNearbyWorldObjects(p);
                }
            }
        }
       
    }
}
