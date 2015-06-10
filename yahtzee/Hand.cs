using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee
{
    public class Hand
    {
        // fields
        public Die[] Dice { get; set; } 

        // properties
        static public int NumDie = 5;

        public int MaxValue { get; set; }

        // constructors
        public Hand() 
        {
            Dice = new Die[NumDie];

            // construct the Dice
            for (int i = 0; i < NumDie; i++)
            {
                // the die is rolled when instantiated
                Dice[i] = new Die();
            }
        }

        // methods
        public int CalcMaxValue()
        {
            foreach (Die value in Dice)
            {
                MaxValue += value.Pips;
            }
            return MaxValue;
        }

        public void Roll()
        {
            for (int i = 0; i < NumDie; i++)
            {
                // the roll method does not change the value if its locked
                 Dice[i].Roll();
            }
        }

        public void Reset()
        {
            // unlocks all die and rolls them
            for (int i = 0; i < NumDie; i++)
            {
                Dice[i].Locked = false;
            }

            Roll();
        }

    }
}
