using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class Chance : ScoringHands
    {

        public override bool ValidCheck(Die[] Dice)
        {
            return true;
        }
        public override int CalcScore(Die[] Dice)
        {
            int score = 0;
            score = Dice.Select(d => d.Pips).Sum();
            return score;
        }








    }
}
