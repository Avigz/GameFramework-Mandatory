using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework_Mandatory
{
    public class Movement
    {
        //statemachine pattern
        private static int _currentState;

        public enum State
        {
            North, South, East, West
        }

        public enum UserInput
        {
            Forward, Right, Left, Backward
        }

        public static int CurrentState
        {
            get => _currentState;
            set => value = _currentState;
        }

        private int[,] states = new int[4, 4]
        {
            {0,1,2,3}, //Fremad
            {2,3,1,0 }, //hoejre
            {3,2,0,1 }, //Venstre
            {1,0,3,2}, //Baglens
        };

        public int Action(int input)
        {
            CurrentState = states[CurrentState, input];
            return CurrentState;
        }
    }
}
