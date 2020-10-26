using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFramework_Mandatory.interfaces
{
   public interface ICharacter
    {

        public Position CharacterPos
        {
            get;
            set;
        }

        public int Hitpoints { get; set; }

        public string Name { get; set; }

        public bool Dead
        {
            get;
            set;
        }
        public List<IEquipment> EquippedItems { get; set; }

        public List<IWeapon> EquippedWeapons { get; set; }

        public void EquipWeapon(IWeapon w)
        {
            if (EquippedWeapons.Count() < 2)
            {
                EquippedWeapons.Add(w);

            }
        }

        public void EquipItem(IEquipment e)
        {
            EquippedItems.Add(e);
            Hitpoints = Hitpoints + e.Hitpoints;
        }


        public int AttackPower
        {

            get
            {
                int result = 0;

                foreach (IWeapon v in EquippedWeapons)
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
            if (Hitpoints - Damage < 0)
            {
                Dead = true;
            }
        }
    }
}
