using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Kar : VerplaatsEntiteit
    {
        public Baan Baan { get; set; }
        public Kar()
        {
            teken = "O";
        }
        public int IsVol
        {
            get => default(int);
            set
            {
            }
        }

        public void Beweeg()
        {
            this.Baan.Beweeg();
        }
    }
}