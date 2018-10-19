using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class GameController
    {

        public Game game { get; set; }
        public GameView gameView { get; set; }

        public GameController()
        {
            game = new Game();
            gameView = new GameView();
            gameView.Start();
        }

        public void Play()
        {
            throw new System.NotImplementedException();
        }
    }
}