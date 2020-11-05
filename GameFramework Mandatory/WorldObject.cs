using GameFramework_Mandatory.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework_Mandatory
{
    public class WorldObject : IWorldObject
    {
        public WorldObject(string name, Position pos, object internalObject)
        {
            Name = name;
            Position = pos;
            InternalObject = internalObject;
        }
        public Position Position
        {
            get; set;
        }

        public string Name { get; set; }

        public object InternalObject
        {
            get; set;
        }
        //public KindOfObjectType kindOfObject
        //{
        //    get
        //    {
        //        if (InternalObject is IWeapon)
        //        {
        //            return KindOfObjectType.Weapon;
        //        }
        //        if (InternalObject is IEquipment)
        //        {
        //            return KindOfObjectType.Equipment;
        //        }
        //        else
        //        {
        //            return KindOfObjectType.Obstacle;
        //        }
        //    }
        //}
    }
}

