using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class FullHouse : Repeats
    {
        // constructors
        public FullHouse()
        {
            Name = "fullHouse";
        }

        // methods
        public override bool ValidCheck(Die[] Dice)
        {
            bool valid = false;
            if (RepeatCheck(Dice, 2) || RepeatCheck(Dice, 3))
            {
                List<int> allPips = Dice.Select(d => d.Pips).OrderBy(d => d).Distinct().ToList();
                int checkDistinct = allPips.Count;
                valid = (checkDistinct == 2);
            }
            return valid;
        }

        public override int CalcScore(Die[] Dice)
        {
            int score = 25;
            return score;
        }

    }
}
