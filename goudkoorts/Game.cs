using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace goudkoorts
{
    public class Game
    {
        public Countdown Count{ get; set;}

        public PlaatsEntiteit[,] Veld;

        public List<VerplaatsEntiteit> Objecten;

        public Loods[] BeginPunten;

        public int Score { get; set; }

        public Boolean Playing { get; set; }

        public Game()
        {
            _generateMap();
            Objecten = new List<VerplaatsEntiteit>();
        }

        public void PlayGame()
        {
            while (Playing)
            {
                //countdown
            }
        }

        private void _generateMap()
        {
            Veld = new PlaatsEntiteit[11, 12];
            BeginPunten[0] = new Loods("A");
            BeginPunten[1] = new Loods("B");
            BeginPunten[2] = new Loods("C");

            for(int i = 0; i < 12; i++)
            {
                Veld[0, i] = new Water();
                Veld[0, i].Next = Veld[1, i - 1];
            }

            Veld[1, 0] = new Baan();
            Veld[1, 0].Teken = "_";

            for (int i = 1; i < 12; i++)
            {
                if(i == 9)
                {
                    Veld[1, i] = new Kade();
                    Veld[1, i].Next = Veld[1, i - 1];
                    Veld[1, i].Teken = "k";
                } else
                {
                    Veld[1, i] = new Baan();
                    Veld[1, i].Next = Veld[1, i - 1];
                    Veld[1, i].Teken = "_";
                }
            }
            Veld[2, 12] = new Baan();
            Veld[2, 12].Next = Veld[1, 12];
            Veld[2, 12].Teken = "|";
            Veld[3, 0] = BeginPunten[0];

            for(int i = 1; i < 12; i++)
            {
                if(i == 4 || i == 10)
                {
                    continue;
                } else
                {
                    Veld[3, i] = new Baan();
                    Veld[3, i].Teken = "_";
                    Veld[3, i - 1].Next = Veld[3, i];
                }
            }

          
           
            Veld[4, 4] = new Baan();
            Veld[4, 4].Teken = "_";
            Veld[4, 10] = new Baan();
            Veld[4, 10].Teken = "_";
            Veld[4, 11] = new Baan();
            Veld[4, 11].Teken = "_";
            Veld[4, 10].Next = Veld[4, 11];
            Veld[4, 11].Next = Veld[3, 11];

            Veld[5, 0] = BeginPunten[1];
            Veld[5, 1] = new Baan();
            Veld[5, 1].Teken = "_";
            Veld[5, 0].Next = Veld[5, 1];
            Veld[5, 2] = new Baan();
            Veld[5, 2].Teken = "_";
            Veld[5, 1].Next = Veld[5, 2];
            Veld[5, 3] = new Baan();
            Veld[5, 3].Teken = "_";
            Veld[5, 5] = new Baan();
            Veld[5, 5].Teken = "_";
            Veld[5, 6] = new Baan();
            Veld[5, 6].Teken = "|";
            Veld[5, 5].Next = Veld[5, 6];
            Veld[5, 8] = new Baan();
            Veld[5, 8].Teken = "|";
            Veld[5, 9] = new Baan();
            Veld[5, 9].Teken = "_";
            Veld[5, 8].Next = Veld[5, 9];

            Veld[6, 7] = new Baan();
            Veld[6, 7].Teken = "_";

            Veld[7, 0] = BeginPunten[2];

            for(int i = 1; i < 12; i++)
            {
                if (i == 11)
                {
                    continue;
                }
                else
                {
                    Veld[7, i] = new Baan();
                    Veld[7, i].Teken = "_";
                    Veld[7, i - 1].Next = Veld[7, i];
                }
            }

            for (int i = 1; i < 12; i++)
            {
                if (i <= 8)
                {
                    Veld[8, i] = new Rangeerterrein();
                    Veld[8, i].Next = Veld[8, i - 1];
                   
                }
                else if (i <= 10)
                {
                    Veld[8, i] = new Baan();
                    Veld[8, i].Next = Veld[8, i - 1];
                    Veld[8, i].Teken = "_";
                } else
                {
                    Veld[8, i] = new Baan();
                    Veld[8, i].Next = Veld[8, i - 1];
                    Veld[8, i].Teken = "|";
                    Veld[7, 11] = new Baan();
                    Veld[7, 11].Next = Veld[8, i];
                    Veld[7, 11].Teken = "_";
                }
            }


            Veld[4, 3] = new Wissel(false, (Baan)Veld[3,3], (Baan)Veld[5,3]);
            Veld[4, 3].Teken = "\\";
            Veld[3, 3].Next = Veld[4, 3];
            Veld[4, 3].Next = Veld[4, 4];
            Veld[4, 5] = new Wissel(true, (Baan)Veld[3,5], (Baan)Veld[5,5]);
            Veld[4, 5].Teken = "/";
            Veld[4,5].Next = Veld[4,5].B
            Veld[4, 4].Next = Veld[4, 5];
            Veld[4, 9] = new Wissel();
            Veld[7, 6] = new Wissel();
            Veld[7, 8] = new Wissel();




        }


    }
}