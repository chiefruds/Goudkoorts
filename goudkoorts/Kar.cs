using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Kar : VerplaatsEntiteit
    {
        public Baan Baan { get; set; }
        public bool IsVol { get; set; }
        public Kar()
        {
            teken = "Ø";
        }

        public void Beweeg()
        {
            this.Baan.Beweeg();
        }
    }
}