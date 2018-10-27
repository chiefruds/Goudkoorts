using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Loods : Baan
    {
        public String Naam { get; set; }

        public Loods(String naam)
        {
            this.Teken = naam;
        }
 
    }
}