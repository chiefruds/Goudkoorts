using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Baan : PlaatsEntiteit
    {
        public Boolean Laatste { get; set; }

        public virtual void Beweeg()
        {
            if(this.Next != null && this.Next.Kar != null)
            {
                Environment.Exit(0);
            }
            if(Kar != null && this.Next != null)
            {
                this.Next.Kar = Kar;
                Kar.Baan = (Baan)this.Next;
                this.Kar = null;
            }

        }
        
        public override String GetTeken()
        {
            if(Kar != null)
            {
                return Kar.teken;
            } else
            {
               return this.Teken;
            }
        }
    }
}