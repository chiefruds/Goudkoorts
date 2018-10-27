using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class Wissel : Baan
    {
        public Baan Boven { get; set; }
        public Baan Beneden { get; set; }

        public Boolean Split { get; set; }
        public Boolean Aan { get; set; }
        public Wissel(Boolean aan, Baan boven, Baan beneden, Boolean split)
        {
            this.Aan = aan;
            this.Boven = Boven;
            this.Beneden = beneden;
            this.Split = split;
        }

        public void Wisselen()
        {
            Aan = !Aan;

            if(Aan && Split)
            {
                this.Next = Boven;
                Teken = "╩";
            } else if(!Aan && Split)
            {
                this.Next = Beneden;
                Teken = "╦";
            } else if(Aan)
            {
                Boven.Next = this;
                Beneden.Next = null;
                Teken = "╩";
            } else if(!Aan)
            {
                Beneden.Next = this;
                Boven.Next = null;
                Teken = "╦";
            }
        }
    }

}