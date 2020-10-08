using GameFramework_Mandatory;
using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter a = new PlayerCharacter(30, "BigJoergen") ;
            PlayerCharacter b = new PlayerCharacter(30, "SmallKim");
            Weapon BigSword = new Weapon(6, true);
            Weapon SmallSword = new Weapon(2, false);
            Equipment Helmet = new Equipment("Helmet", 3);
            Equipment ShinGuard = new Equipment("ShinGuard", 10);
            a.EquipWeapon(BigSword);
            b.EquipWeapon(SmallSword);
            b.EquipWeapon(SmallSword);
            a.EquipItem(Helmet);
            a.EquipItem(ShinGuard);
            b.EquipItem(ShinGuard);
            b.EquipItem(ShinGuard);
            FightSim fighting = new FightSim();

            fighting.Fight(a, b);
        }
    }
}
