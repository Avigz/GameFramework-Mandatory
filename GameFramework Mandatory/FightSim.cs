using System;
using System.Collections.Generic;
using System.Text;
using GameFramework_Mandatory.interfaces;

namespace GameFramework_Mandatory
{
   public class FightSim
    {
        private Random _rnd = new Random();

        public void Fight(ICharacter a, ICharacter b)
        {
            if (_rnd.Next(2) == 1)
            {
                Console.WriteLine("Character " + a.Name + " Took the first swing");
                while(a.Dead == false && b.Dead == false)
                {
                    b.TakeDamage(a.Attack());
                    Console.WriteLine(b.Name + " has " + b.Hitpoints + " hitpoints left");
                    if (b.Dead == false)
                    {
                        a.TakeDamage(b.Attack());
                        Console.WriteLine(a.Name + " has " + a.Hitpoints + " hitpoints left");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Character " + b.Name + " Took the first swing");
                while (a.Dead == false && b.Dead == false)
                {
                    a.TakeDamage(b.Attack());
                    Console.WriteLine(a.Name + " has " + a.Hitpoints + " hitpoints left");
                    if(a.Dead == false) { 
                    b.TakeDamage(a.Attack());
                    Console.WriteLine(b.Name + " has " + b.Hitpoints + " hitpoints left");
                    }
                }
            }

        }
    }
    
}
