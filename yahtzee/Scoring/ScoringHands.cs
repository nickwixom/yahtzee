using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public abstract class ScoringHands
    {
        // properties
        public int Score { get; set; }

        public string Name { get; set; }

        public bool Valid { get; set; }


        // methods
        public abstract bool ValidCheck(Die[] Dice);

        public abstract int CalcScore(Die[] Dice);

    }
}
