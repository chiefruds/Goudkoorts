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
        public String[,] StringArray { get; }

        public GameController()
        {
            game = new Game();
            gameView = new GameView();
            StringArray = new string[game.Veld.GetLength(0), game.Veld.GetLength(1)];
            GenerateStringArray();
            gameView.PrintField(StringArray);
            //gameView.Start();
        }

        public void GenerateStringArray()
        {
            for(int i = 0; i < game.Veld.GetLength(0); i++)
            {
                for(int j = 0; j < game.Veld.GetLength(1); j++)
                {
                    if(game.Veld[i,j] != null)
                    {
                        StringArray[i, j] = game.Veld[i, j].Teken;
                    }
                    
                }
            }
        }
        public void Play()
        {
            throw new System.NotImplementedException();
        }
    }
}