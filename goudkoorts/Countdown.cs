using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace goudkoorts
{
    public class Countdown
    {
        Timer MoveTimer;
        private GameController gc;

        public Countdown(GameController gc)
        {
            this.gc = gc;
            MoveTimer = new Timer(2000);
            MoveTimer.Elapsed += MoveTimer_elapsed;
            MoveTimer.Start();
        }

        private void MoveTimer_elapsed(object sender, ElapsedEventArgs e)
        {
            gc.MoveAnimatie();
        }
    }
}