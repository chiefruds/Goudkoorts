using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace goudkoorts
{
    public class Countdown
    {
        Timer timer;
        private GameController gc;

        public Countdown(GameController gc)
        {
            this.gc = gc;
            timer = new Timer(500);
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            gc.SchipAnimatie();
        }
    }
}