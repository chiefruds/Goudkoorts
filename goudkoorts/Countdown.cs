using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace goudkoorts
{
    public class Countdown
    {
        Thread th;

        public Countdown(Game game)
        {
            th = new Thread(game.SchipAnimatie);
        }
    }
}