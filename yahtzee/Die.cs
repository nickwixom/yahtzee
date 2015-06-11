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
        Random rnd = new Random(Guid.NewGuid().GetHashCode());

        // properties
        // value of dice
        private int pips = 1;
        private bool locked = false;
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
        public bool Locked 
        {
            get { return locked; }
            set
            {
                locked = value;

                PropertyChanged.Raise(this, "Locked");
            }
        }


        // constructors
        public Die() 
        {
            Locked = false;
        }

        // methods
        public void Roll()
        {

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
