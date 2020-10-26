using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using GameFramework_Mandatory.interfaces;

namespace GameFramework_Mandatory
{
    public class PlayerCharacter: ICharacter

    {
    private int _hitpoints;
    private string _name;
    private bool _dead = false;
    private Position _position;
    private List<IEquipment> _equippedItems = new List<IEquipment>();
    private List<IWeapon> _equippedWeapons = new List<IWeapon>(2);

        public PlayerCharacter(int hitpoints, string name, Position position)
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
        get { return _hitpoints; }

        set
        {
            if (value >= 0)
            {
                _hitpoints = value;
            }


        }
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public bool Dead
    {
        get => _dead;
        set
        {
            _dead = value;
            if (Dead == true)
            {
                Console.WriteLine("The Character " + Name + " has died!");
                Hitpoints = 0;
            }
        }
    }


    public List<IEquipment> EquippedItems
    {
        get { return _equippedItems; }
        set { _equippedItems = EquippedItems; }

    }

    public List<IWeapon> EquippedWeapons
    {
        get { return _equippedWeapons; }
        set { _equippedWeapons = EquippedWeapons; }
    }

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
            Console.WriteLine(Name + " Dealt " + AttackPower + " hitpoints of damage");
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
