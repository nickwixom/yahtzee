using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public abstract class TopHalfScoringHands
    {
        // fields



        // properties
        public int Score { get; set; }

        public string Name { get; set; }

        abstract public int BasePip { get; set; }

        public bool Valid { get; set; }


        // constructors
        public TopHalfScoringHands() { }


        // methods
        abstract public bool ValidCheck(Die[] Dice)
        {
            // problems...
            /*
            foreach (Die value in Dice)
            {
                if (value.Pips == BasePip)
                {
                    Valid = true;
                }
            }
            return Valid;
             */
            // why not...?
            Valid = Dice.Any(item => item.Pips == BasePip);
            return Valid;
        }

        public int CalcScore(Die[] Dice)
        {
            // there should be a better way...
            foreach (Die element in Dice)
            {
                if (element.Pips == BasePip)
                {
                    Score += element.Pips;
                }
            }
            return Score;
        }
        

    }
}
