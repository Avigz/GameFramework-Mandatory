using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework_Mandatory
{
   public class WorldObject
    {
        public Position Position
        {
            get;set;
        }

        public string Name { get; set; }
       
        public Delegate InternalObject
        {
            get;set;
        }
        

    }
}
