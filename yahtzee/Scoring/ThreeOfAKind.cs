using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class ThreeOfAKind : Repeats
    {
        // constructors
        public ThreeOfAKind() 
        {
            Name = "3 of a kind";
        }

        // methods
        public override bool ValidCheck(Die[] Dice)
        {
            bool checkRepeat = RepeatCheck(Dice, 3);
            return checkRepeat;
        }

        public override int CalcScore(Die[] Dice)
        {
            int score = 0;
            score = Dice.Select(d => d.Pips).Sum();
            return score;
        }









    }
}
