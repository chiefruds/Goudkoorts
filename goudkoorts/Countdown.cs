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
        Timer GenerateTimer;
        private GameController gc;

        public Countdown(GameController gc)
        {
            this.gc = gc;
            MoveTimer = new Timer(2000);
            MoveTimer.Elapsed += MoveTimer_elapsed;
            MoveTimer.Start();

            GenerateTimer = new Timer(10000);
            GenerateTimer.Elapsed += GenerateTimer_elapsed;
            GenerateTimer.Start();
        }

        private void MoveTimer_elapsed(object sender, ElapsedEventArgs e)
        {
            gc.MoveAnimatie();
        }

        private void GenerateTimer_elapsed(object sender, ElapsedEventArgs e)
        {
            gc.game.GenereerKar();
   
        }
    }
}