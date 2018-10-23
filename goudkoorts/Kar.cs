using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Kar : VerplaatsEntiteit
    {
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

        public Baan Baan
        {
            get => default(Baan);
            set
            {
            }
        }

        public void Beweeg()
        {
            throw new System.NotImplementedException();
        }
    }
}