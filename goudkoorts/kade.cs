using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Kade : Baan
    {

       public Schip schip { get; set; }

       public Water water { get; set; }

        public void LaadSchip()
        {
            if(water.Schip != null)
            {
                water.Schip.KanBewegen = false;
            }
            
            if(this.Kar != null && water.Schip != null)
            {
                water.Schip.VulSchip();
                this.Kar.IsVol = false;
                this.Kar.teken = "O";
            }
        }

        public override void Beweeg()
        {
            if (Kar != null && this.Next != null)
            {
                this.Next.Kar = Kar;
                Kar.Baan = (Baan)this.Next;
                this.Kar = null;
            }

            if (water.Schip != null)
            {

                LaadSchip();

                if (water.Schip.KanBewegen)
                {
                    water.Next.Schip = schip;
                    schip = null;
                }
            }
        }
    }
}