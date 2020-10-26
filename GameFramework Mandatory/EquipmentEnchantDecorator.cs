using System;
using System.Collections.Generic;
using System.Text;
using GameFramework_Mandatory.interfaces;

namespace GameFramework_Mandatory
{
    public class EquipmentEnchantDecorator : IEquipment
    {
        public EquipmentEnchantDecorator(IEquipment equipment)
        {
            _equipment = equipment;
        }

        private readonly IEquipment _equipment;

        public string Name
        {
            get { return _equipment.Name; }
            set { Name = "Enchanted" + _equipment.Name; }
        }
        public int Hitpoints
        {
            get { return _equipment.Hitpoints*2; }
            set { _equipment.Hitpoints = Hitpoints; }
        }
    }
}
