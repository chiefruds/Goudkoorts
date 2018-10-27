using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class PlaatsEntiteit
    {
        public PlaatsEntiteit Next { get; set; }

        public Kar Kar { get; set; }

        public String Teken { get; set; }

        public virtual String GetTeken()
        {
            return Teken;
        }
    }
}