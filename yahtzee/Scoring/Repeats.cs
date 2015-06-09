using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public abstract class Repeats : ScoringHands
    {
        // methods
        public bool RepeatCheck(Die[] Dice, int numRepeat)
        {
            List<int> allPips = Dice.Select(d => d.Pips).ToList();

            bool valid = false;

            for (int i = 1; i <= 6; i++)
            {
                valid = allPips.Count(p => p == i) >= numRepeat;

                if (valid) break;
            }

            return valid;
        }


    }
}
