using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class Ones : TopHalfScoringHands
    {
        // fields


        // properties
        private int BasePip = 1;


        // constructors
        public Ones(Die[] Dice) 
        {
            Valid = ValidCheck(Dice);
            Score = CalcScore(Dice);
        }

        // methods


    }
}
