using GameFramework_Mandatory;
using GameFramework_Mandatory.interfaces;
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter a = new PlayerCharacter(30, "BigJoergen", new Position(1, 2));
            PlayerCharacter b = new PlayerCharacter(30, "SmallKim", new Position(1, 3));
            Sword BigSword = new Sword(6, true, "excalibur");
            Sword SmallSword = new Sword(3, false, "Smoerkniv");
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
            WorldObject obj1 = new WorldObject("FalskSten", new Position(1, 1), ShinGuard);
            WorldSingletonFactory gameworld = WorldSingletonFactory.CreateInstance(new Position(10,10));
            gameworld.Objects.Add(obj1);
            gameworld.Characters.Add(a);
            gameworld.Characters.Add(b);
            Game engine = new Game(gameworld);
            Console.WriteLine(a.NearbyCharacter(b));
            Console.WriteLine(a.Hitpoints);
            Console.WriteLine(a.GetNearbyWorldObjects(obj1));
            Console.WriteLine(a.Hitpoints);
            //engine.GetFights();
            engine.GetWorldObjects();
            
        }
    }
}
