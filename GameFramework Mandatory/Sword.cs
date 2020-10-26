using System;
using System.Collections.Generic;
using System.Text;
using GameFramework_Mandatory.interfaces;

namespace GameFramework_Mandatory
{
    public class Sword : IWeapon
    {
        public Sword(int damage, bool twohanded)
        {
            if (twohanded)
            {
                MinDamage = damage / 2;
                MaxDamage = damage * 2;
            }
            else
            {
                MinDamage = damage / 2;
                MaxDamage = damage * 5 / 2;
            }

        }
        private double _minDamage;
        private double _maxDamage;
        public double MinDamage { get => _minDamage; set => _minDamage = value; }
        public double MaxDamage { get => _maxDamage; set => _maxDamage = value; }

        private Random rng = new Random();

        public int DoAttack()
        {

            return rng.Next((int)Math.Floor(MinDamage), (int)Math.Floor(MaxDamage));
        }

        public bool TwoHanded { get; set; }

    }
}
