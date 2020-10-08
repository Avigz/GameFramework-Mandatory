using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework_Mandatory
{
   public class KeyboardController
    {
     public KeyboardController() 
        { 

        }

        public ConsoleKey KeyStrokes = Console.ReadKey(intercept: true).Key;

        public int KeyInput()
        {
            switch(KeyStrokes)
            {
                case ConsoleKey.UpArrow:
                    return (int)Movement.UserInput.Forward;
                case ConsoleKey.RightArrow:
                    return (int)Movement.UserInput.Right;
                case ConsoleKey.LeftArrow:
                    return (int)Movement.UserInput.Left;
                case ConsoleKey.DownArrow:
                    return (int)Movement.UserInput.Backward;

                default:
                    return Movement.CurrentState;
            }
        }
    }
}
