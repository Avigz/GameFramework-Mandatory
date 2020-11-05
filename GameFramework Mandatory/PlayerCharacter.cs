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
        _position = position;
    }

    public Position CharacterPos
    {
        get { return _position; }
        set { _position = value; }
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

    public bool NearbyCharacter(ICharacter C)
        {
            if (C.CharacterPos.X >= CharacterPos.X-1 && C.CharacterPos.X <= CharacterPos.X + 1 || C.CharacterPos.X == CharacterPos.X)
            {
                if (C.CharacterPos.Y >= CharacterPos.Y - 1 && C.CharacterPos.Y <= CharacterPos.Y + 1 || C.CharacterPos.Y == CharacterPos.Y)
                {
                    return true;
                }
                
            }
            return false; 
        }

    public bool GetNearbyWorldObjects(IWorldObject item)
        {
            if (item.Position.X >= CharacterPos.X - 1 && item.Position.X <= CharacterPos.X + 1 || item.Position.X == CharacterPos.X)
            {
                if (item.Position.Y >= CharacterPos.Y - 1 && item.Position.Y <= CharacterPos.Y + 1 || item.Position.Y == CharacterPos.Y)
                {
                    //if (item.InternalObject.GetType() is IWeapon)
                    //{
                    //    Console.WriteLine("Du har fundet " + item.Name);
                    //    EquipWeapon((IWeapon)item.InternalObject);
                    //    return true;
                    //}
                    //if (item.InternalObject.GetType() is IEquipment)
                    //{
                    //    Console.WriteLine("Du har fundet " + item.Name);
                    //    EquipItem((IEquipment)item.InternalObject);
                    //    return true;
                    //}
                    //else return false;

                    switch (item.InternalObject)
                    {
                        case IWeapon:
                            Console.WriteLine("Du har fundet " + (IWeapon)item.InternalObject);
                            EquipWeapon((IWeapon)item.InternalObject);
                            return true;
                            
                        case IEquipment:
                            Console.WriteLine("Du har fundet " + (IEquipment)item.InternalObject);
                            EquipItem((IEquipment)item.InternalObject);
                            return true;
                            
                        case null:
                            Console.WriteLine(item.Name + " Indeholder ingenting");
                            return true;
                            
                        default:
                            return false;
                            
                    }
                }
                else return false;

            }
            else
                return false;
        }

    }
}
