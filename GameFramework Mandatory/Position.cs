using GameFramework_Mandatory.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GameFramework_Mandatory
{
    public class Position : IPosition
    {
        public Position(int x, int y)
        {
            _x = x;
            _y = y;
        }
        private int _x;
        private int _y;


        public int Y { get => _y; set{ if (value >= 0) { _y = value; } } }
        public int X { get => _x; set{ if (value >= 0) { _x = value; } } }
    }
}
