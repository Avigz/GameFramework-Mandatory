﻿using System;
using System.Collections.Generic;
using System.Text;
using GameFramework_Mandatory.interfaces;

namespace GameFramework_Mandatory
{
    public class Equipment : IEquipment
    {
        private string _name;
        private int _hitpoints;

        public Equipment(string name, int hitpoints)
        {
            Name = name;
            Hitpoints = hitpoints;
        }
        public string Name { get => _name; set => _name = value; }

        public int Hitpoints { get => _hitpoints; set => _hitpoints = value; }


    }
}
