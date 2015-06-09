using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class LargeStraight : Straights
    {
        // fields
        

        // properties
        

        // constructors
        public LargeStraight() { }


        // methods
        public override bool ValidCheck(Die[] Dice)
        {
            bool checkConsecutive = IsConsecutive(Dice, 5);
            return checkConsecutive;
        }
        public override int CalcScore(Die[] Dice)
        {
            int score = 40;
            return score;
        }

    }
}
