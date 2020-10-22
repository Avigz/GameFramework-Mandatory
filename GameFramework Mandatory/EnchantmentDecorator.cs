using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework_Mandatory
{
    public class EnchantmentDecorator : IWeapon
    {
        public EnchantmentDecorator(IWeapon weapon)
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

        public int DoAttack()
        {
            return _weapon.DoAttack();
        }
    }
}
