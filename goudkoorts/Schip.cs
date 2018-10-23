using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Schip : VerplaatsEntiteit
    {

        public int Lading;
        public bool Aangemeerd;

        public Schip()
        {
            teken = "<  >";
        }
    }
}