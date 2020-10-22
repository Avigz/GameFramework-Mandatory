using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GameFramework_Mandatory
{
    public abstract class Character
    {
        private int _hitpoints;
        private string _name;
        private bool _dead = false;
        private Position _position;

        public Character(int hitpoints, string name, Position position)
        {
            Hitpoints = hitpoints;
            Name = name;
            CharacterPos = position;
        }

        public Position CharacterPos
        {
            get { return _position; }
            set { _position = CharacterPos; }
        }


        public int Hitpoints
        {
            get { 
  
                return _hitpoints; }

            set
            {
                if (value >= 0)
                {
                    _hitpoints = value;
                }

                
            }
        }

        public string Name { get => _name; set => _name = value; }

        public bool Dead
        {
            get => _dead;
            set
            {
                _dead = value;
                if (Dead == true)
                {
                    Console.WriteLine("The Character " + Name + " has died!" );
                    Hitpoints = 0;
                }
            }
        }


        public List<Equipment> EquippedItems = new List<Equipment>();

        public List<Weapon> EquippedWeapons = new List<Weapon>(2);

        public void EquipWeapon(Weapon w) {
            if (EquippedWeapons.Count() < 2)
            {
                EquippedWeapons.Add(w);

            }
        }

        public void EquipItem(Equipment e)
        {
            EquippedItems.Add(e);
            Hitpoints = Hitpoints + e.Hitpoints;
        }


        public int AttackPower {
            
            get {
                int result = 0;

                foreach (Weapon v in EquippedWeapons) 
                {
                    result = result + v.DoAttack();

                }
                return result;
            }
                 }

       

        public int Attack()
        {
            return AttackPower;

        }

        public void Move()
        {

        }

        public void TakeDamage(int Damage)
        {
            Hitpoints = Hitpoints - Damage;
            if(Hitpoints - Damage < 0)
            {
                Dead = true;
            }
        }
    }
}
