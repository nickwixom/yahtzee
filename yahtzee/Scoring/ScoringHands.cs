using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public abstract class ScoringHands : INotifyPropertyChanged
    {
        // properties
        int score = 0;
        bool valid = false;
        public int Score
        {
            get { return score; }
            set
            {
                score = value;

                PropertyChanged.Raise(this, "Score");
            }
        }

        public string Name { get; set; }

        public bool Valid
        {
            get { return valid; }
            set
            {
                valid = value;

                PropertyChanged.Raise(this, "Valid");
            }
        }

        public Player AssociatedPlayer { get; set; }




        // methods
        public abstract bool ValidCheck(Hand hand);

        public abstract int CalcScore(Hand hand);



        public event PropertyChangedEventHandler PropertyChanged;
    }
}
