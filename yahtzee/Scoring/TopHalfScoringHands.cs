using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class TopHalfScoringHands : ScoringHands
    {
        // fields



        // properties

        public int BasePip { get; set; }

        // constructors
        public TopHalfScoringHands(int basePip) 
        {
            BasePip = basePip;
        }

        // methods
        public bool ValidCheck(Die[] Dice)
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
