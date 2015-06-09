﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class FourOfAKind : Repeats
    {
        // constructors
        public FourOfAKind() { }

        // methods
        public override bool ValidCheck(Die[] Dice)
        {
            bool checkRepeat = RepeatCheck(Dice, 4);
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