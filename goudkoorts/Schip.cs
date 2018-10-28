using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Schip : VerplaatsEntiteit
    {
        public Water Lokatie { get; set; }
        public int Lading;
        public bool Aangemeerd;

        public Schip()
        {
            teken = "<  >";
            Lading = 0;
            KanBewegen = true;
        }

        public void VulSchip()
        {
            Lading++;
            KanBewegen = false;
            if (Lading > 3)
            {
                teken = "<o >";
            } else if(Lading > 5)
            {
                teken = "<oo >";
            } else if (Lading == 1 )
            {
                teken = "<ooo>";
                KanBewegen = true;
                Beweeg();
            }
           
        }

        public void Beweeg()
        {
            if (KanBewegen)
            {
                this.Lokatie.Beweeg();
            }
        }

        public Boolean KanBewegen { get; set; }

    }
}