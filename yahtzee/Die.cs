using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee
{
    public class Die
    {
        // fields
        private Random rnd = new Random();

        // properties
        // value of dice
        public int Pips { get; set; }

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
            if (!Locked)
            {
                Pips = rnd.Next(1, 6);
            }
        }
               






    }
}
