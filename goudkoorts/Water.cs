using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Water : PlaatsEntiteit
    {
        public Water()
        {
            this.Teken = "~";
        }

        public override String GetTeken()
        {
            if(this.Schip != null)
            {
                return Schip.teken;
            } else
            {
                return this.Teken;
            }
        }

        public void Beweeg()
        {
            if (this.Next != null)
            {
                this.Schip.Lokatie = (Water)this.Next;
                this.Next.Schip = Schip;
            }
            this.Schip = null;

        }
    }
}