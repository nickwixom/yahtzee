using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee
{
    public class Die : INotifyPropertyChanged
    {
        // fields
        

        // properties
        // value of dice
        private int pips = 1;
        public int Pips 
        {
            get { return pips; }
            set
            {
                pips = value;

                PropertyChanged.Raise(this, "Pips");
            }
        }

        // is dice locked
        public bool Locked { get; set; }


        // constructors
        public Die() 
        {
            Locked = false;

            // make pips random
            Roll();
        }

        // methods
        public void Roll()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            if (!Locked)
            {
                Pips = rnd.Next(1, 6);
            }
        }

        public override string ToString()
        {
            return Pips.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
