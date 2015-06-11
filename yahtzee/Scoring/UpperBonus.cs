using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using yahtzee.Scoring;

namespace yahtzee.Scoring
{
    public class UpperBonus : ScoringHands
    {
        // properties


        // constrctors
        public UpperBonus()
        {
            Name = "Bonus";

        }

        // methods
        public bool CheckUpperScores(List<ScoringHands> upperScoring)
        {
            bool valid = false;
            int total = 0;
            foreach (ScoringHands s in upperScoring)
            {
                total += s.Score;
            }
            if (total >= 63)
            {
                valid = true;
            }
            return valid;
        }

        public int CalcUpperScore(List<ScoringHands> upperScoring)
        {
            int score = 0;
            int total = 0;
            foreach (ScoringHands s in upperScoring)
            {
                total += s.Score;
            }
            if (total >= 63)
            {
                score = 35;
            }
            return score;

        }


        public override bool ValidCheck(Die[] Dice)
        {
            throw new NotImplementedException();
        }

        public override int CalcScore(Die[] Dice)
        {
            throw new NotImplementedException();
        }
    }
}
