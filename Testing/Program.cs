using GameFramework_Mandatory;
using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter a = new PlayerCharacter(30, "BigJoergen",new Position(1,2)) ;
            PlayerCharacter b = new PlayerCharacter(30, "SmallKim",new Position(1,3));
            Sword BigSword = new Sword(6, true, "excalibur");
            Sword SmallSword = new Sword(2, false, "Smoerkniv");
            WeaponEnchantmentDecorator EnchantedSword = new WeaponEnchantmentDecorator(SmallSword);
            Equipment Helmet = new Equipment("Helmet", 3);
            Equipment ShinGuard = new Equipment("ShinGuard", 10);
            a.EquipWeapon(BigSword);
            b.EquipWeapon(EnchantedSword);
            b.EquipWeapon(EnchantedSword);
            a.EquipItem(Helmet);
            a.EquipItem(ShinGuard);
            b.EquipItem(ShinGuard);
            b.EquipItem(ShinGuard);
            FightSim fighting = new FightSim();

            fighting.Fight(a, b);
        }
    }
}
