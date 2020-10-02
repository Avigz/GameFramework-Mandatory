using System.Collections.Generic;

namespace GameFramework_Mandatory
{
    public class Character
    {
        public Character(int hitpoints )
        {
            Hitpoints = hitpoints;
        }

        public int Hitpoints { get; set; }
        public IEnumerable<Equipment> EquippedItems = new List<Equipment>();
        public IEnumerable<Weapon> EquippedWeapons = new List<Weapon>(2);

        public int AttackPower { get; set; }

        public void Attack()
        {

        }

        public void Move()
        {

        }
    }
}
