﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework_Mandatory
{
   public class PlayerCharacter : Character
   {
        

        public PlayerCharacter() : base(hitpoints)
        {
            Hitpoints = hitpoints;
        }
    }
}