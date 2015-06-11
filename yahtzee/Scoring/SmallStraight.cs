using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class SmallStraight : Straights
    {
        // constructors
        public SmallStraight() 
        {
            Name = "Sm. Straight";
        }

        // methods
        public override bool ValidCheck(Die[] Dice)
        {
            bool checkConsecutive = IsConsecutive(Dice, 4);
            return checkConsecutive;
        }

        public override int CalcScore(Die[] Dice)
        {
            int score = 30;
            return score;
        }








    }
}
