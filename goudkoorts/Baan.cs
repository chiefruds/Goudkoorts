using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Baan : PlaatsEntiteit
    {

        public Kar kar { get; set; }

        public Kar Kar
        {
            get => default(Kar);
            set
            {
            }
        }
    }
}