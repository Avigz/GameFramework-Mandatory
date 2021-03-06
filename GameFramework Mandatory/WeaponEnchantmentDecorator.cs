﻿using System;
using System.Collections.Generic;
using System.Text;
using GameFramework_Mandatory.interfaces;

namespace GameFramework_Mandatory
{
    public class WeaponEnchantmentDecorator : IWeapon
    {
        public WeaponEnchantmentDecorator(IWeapon weapon)
        {
            _weapon = weapon;
        }

        private readonly IWeapon _weapon;

        public double MaxDamage
        {
            get => _weapon.MaxDamage;
            set
            {
                MaxDamage = _weapon.MaxDamage;
            }
        }
        public double MinDamage { get => _weapon.MaxDamage;
            set
            {
                MinDamage = _weapon.MinDamage;
            }
        }
        public bool TwoHanded { get => _weapon.TwoHanded; }

        public string Name { get => "Enchanted " + _weapon.Name; set { _weapon.Name = Name; } }

        public int DoAttack()
        {
            return _weapon.DoAttack();
        }
    }
}
