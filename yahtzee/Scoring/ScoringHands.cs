using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    class ScoringHands
    {
        // properties
        public int Score { get; set; }

        public string Name { get; set; }

        public bool Valid { get; set; }


        // methods
        abstract public bool ValidCheck(Die[] Dice);

    }
}
