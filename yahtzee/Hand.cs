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
        static public int NumDie = 5;


        // properties
        
        public Die[] Dice { get; set; }

        public int RollNumber { get; set; }


        // constructors
        public Hand() 
        {
            Dice = new Die[NumDie];

            // construct the Dice
            for (int i = 0; i < NumDie; i++)
            {
                // the die is rolled when instantiated
                Dice[i] = new Die();
                // make each image blank on first load
                Dice[i].Pips = 0;
            }
        }

        // methods
        public void Roll()
        {
            for (int i = 0; i < NumDie; i++)
            {
            // the roll method does not change the value if its locked
            Dice[i].Roll();
            }
            RollNumber++;
        }

        public void Reset()
        {
            // unlocks all die and rolls them
            for (int i = 0; i < NumDie; i++)
            {
                Dice[i].Locked = false;
                Dice[i].Pips = 0;
            }

            RollNumber = 1;
        }


    }
}
