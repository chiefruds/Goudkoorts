using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Baan
    {

        public Baan Next { get; set; }
        public Baan Previous { get; set; }


        public Kar Kar
        {
            get => default(Kar);
            set
            {
            }
        }
    }
}