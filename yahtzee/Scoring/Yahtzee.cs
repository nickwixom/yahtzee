using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class Yahtzee : Repeats
    {
        // fields


        // properties


        // constructors
        public Yahtzee() 
        {
            Name = "YAHTZEE";
        }

        // methods
        public override bool ValidCheck(Die[] Dice)
        {
            bool checkRepeat = RepeatCheck(Dice, 5);
            return checkRepeat;
        }

        public override int CalcScore(Die[] Dice)
        {
            int score = 50;
            return score;
        }





    }
}
