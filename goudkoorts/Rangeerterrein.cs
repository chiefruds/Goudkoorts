using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Rangeerterrein : Baan
    {
        public Rangeerterrein()
        {
            this.Teken = "R";
        }
        public override void Beweeg()
        {
            if (Kar != null && this.Next != null)
            {
                if(this.Next.Kar == null)
                {
                    this.Next.Kar = Kar;
                    Kar.Baan = (Baan)this.Next;
                    this.Kar = null;
                }             

            }
        }
    }
}