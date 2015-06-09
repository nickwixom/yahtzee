using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee
{
    public class Hand
    {
        // fields
        public Die[] Dice = new Die[NumDie];

        
        // properties
        static public int NumDie = 5;

        public int MaxValue { get; set; }

        // constructors
        public Hand() 
        {
            
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

    }
}
