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

        public Water RechtsBoven;

        public List<VerplaatsEntiteit> Objecten;

        public Loods[] BeginPunten;

        public Wissel[] Wissels;

        public int Score { get; set; }

        public Boolean Playing { get; set; }

        Kade kade;

        public List<Kar> KarLijst = new List<Kar>();

        private Kar TestKar = new Kar();

        private PlaatsEntiteit Locatie;

        private Schip[] schip = new Schip[5];
        private List<Schip> schipp = new List<Schip>();

        public Game(GameController gc)
        {
            _generateMap();
            Objecten = new List<VerplaatsEntiteit>();
            Count = new Countdown(gc);
            schipp.Add(new Schip());
            schipp[0].Lokatie = RechtsBoven;
            RechtsBoven.Schip = schipp[0];
            GenereerKar();
            kade = (Kade)Veld[1, 9];

        }

        public void SchipAnimatie()
        {
            for(int i = 0; i < schipp.Count(); i++)
            {
                if(schipp[i] != null)
                {
                    schipp[i].Beweeg();
                    if (schipp[i].Lading == 8)
                    {
                        schipp[i].Lading = 0;

                        GenereerSchip();

                    }
                }
            }
           
            kade.LaadSchip();
            
        }

        public void GenereerSchip()
        {
            Score += 10;
            schipp.Add(new Schip { Lokatie = RechtsBoven });
            RechtsBoven.Schip = schipp.Last();

        }

        public void GenereerKar()
        {
            Random rand = new Random();
            int random = rand.Next(3);

            Kar kar = new Kar();
            BeginPunten[random].Next.Kar = kar;
            kar.Baan = (Baan)BeginPunten[random].Next;
            KarLijst.Add(kar);
        }

        public void KarAnimatie()
        {
           
          for(int i = 0; i < KarLijst.Count(); i++)
            {
                 KarLijst[i].Beweeg();
            }
          if(Veld[1,0].Kar != null)
            {
                Veld[1, 0].Kar = null;
            }
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
            BeginPunten = new Loods[3];
            Veld = new PlaatsEntiteit[9, 12];
            BeginPunten[0] = new Loods("A");
            BeginPunten[1] = new Loods("B");
            BeginPunten[2] = new Loods("C");

            RechtsBoven = new Water();
            Veld[0, 0] = new Water();
            for(int i = 1; i < 12; i++)
            {
                if (i == 11)
                {
                    Veld[0, i] = RechtsBoven;
                }
                else
                {
                    Veld[0, i] = new Water();
                }
                Veld[0, i].Next = Veld[0, i - 1];
            }

            Veld[1, 0] = new Baan();
            Baan baan = (Baan)Veld[1, 0];
            baan.Laatste = true;
            Veld[1, 0].Teken = "=";

            for (int i = 1; i < 12; i++)
            {
                if(i == 9)
                {
                    Veld[1, i] = new Kade();
                    Veld[1, i].Next = Veld[1, i - 1];
                    Veld[1, i].Teken = "k";
                    Kade kade = (Kade)Veld[1, i];
                    kade.water = (Water)Veld[0, 9];
                    
                } else
                {
                    Veld[1, i] = new Baan();
                    Veld[1, i].Next = Veld[1, i - 1];
                    Veld[1, i].Teken = "=";
                }
            }
            Veld[2, 11] = new Baan();
            Veld[2, 11].Next = Veld[1, 11];
            Veld[2, 11].Teken = "║";
            Veld[3, 0] = BeginPunten[0];

            for(int i = 1; i < 12; i++)
            {
                if(i == 4 || i == 10)
                {
                    continue;
                } else if(i == 11) 
                {
                    Veld[3, i] = new Baan();
                    Veld[3, i].Teken = "╩";
                    Veld[3, i].Next = Veld[2, 11];
                }
                else
                {
                    Veld[3, i] = new Baan();
                    Veld[3, i].Teken = "=";
                    if(Veld[3,i -1] != null)
                    {
                        Veld[3, i - 1].Next = Veld[3, i];
                    }
                   
                }
            }
            
            Veld[4, 4] = new Baan();
            Veld[4, 4].Teken = "=";
            Veld[4, 10] = new Baan();
            Veld[4, 10].Teken = "=";
            Veld[4, 11] = new Baan();
            Veld[4, 11].Teken = "=";
            Veld[4, 10].Next = Veld[4, 11];
            Veld[4, 11].Next = Veld[3, 11];

            Veld[5, 0] = BeginPunten[1];
            Veld[5, 1] = new Baan();
            Veld[5, 1].Teken = "=";
            Veld[5, 0].Next = Veld[5, 1];
            Veld[5, 2] = new Baan();
            Veld[5, 2].Teken = "=";
            Veld[5, 1].Next = Veld[5, 2];
            Veld[5, 3] = new Baan();
            Veld[5, 3].Teken = "=";
            Veld[5, 2].Next = Veld[5, 3];
            Veld[5, 5] = new Baan();
            Veld[5, 5].Teken = "=";
            Veld[5, 6] = new Baan();
            Veld[5, 6].Teken = "=";
            Veld[5, 5].Next = Veld[5, 6];
            Veld[5, 8] = new Baan();
            Veld[5, 8].Teken = "=";
            Veld[5, 9] = new Baan();
            Veld[5, 9].Teken = "=";
            Veld[5, 8].Next = Veld[5, 9];

            Veld[6, 7] = new Baan();
            Veld[6, 7].Teken = "=";

            Veld[7, 0] = BeginPunten[2];

            for(int i = 1; i < 12; i++)
            {
                if (i == 11 || i == 7)
                {
                    continue;
                }
                else
                {
                    Veld[7, i] = new Baan();
                    Veld[7, i].Teken = "=";
                    if (Veld[7, i - 1] != null)
                    {
                        Veld[7, i - 1].Next = Veld[7, i];
                    }
                       
                }
            }
            Veld[7, 11] = new Baan();
            Veld[7, 11].Teken = "╦";
            Veld[7, 9].Next = Veld[7, 10];
            Veld[7, 10].Next = Veld[7, 11];
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
                    Veld[8, i].Teken = "=";
                } else
                {
                    Veld[8, i] = new Baan();
                    Veld[8, i].Next = Veld[8, i - 1];
                    Veld[8, i].Teken = "╩";
                    Veld[7, 11].Next = Veld[8, i];
                    
                }
            }
           

            Veld[4, 3] = new Wissel(false, (Baan)Veld[3,3], (Baan)Veld[5,3], false);
            Veld[4, 3].Teken = "╦";
            Veld[3, 3].Next = Veld[4, 3];
            Veld[4, 3].Next = Veld[4, 4];
            Veld[4, 5] = new Wissel(true, (Baan)Veld[3,5], (Baan)Veld[5,5], true);
            Veld[4, 5].Teken = "╩";
            Veld[4, 5].Next = Veld[3, 5];
            Veld[4, 4].Next = Veld[4, 5];
            Veld[4, 9] = new Wissel(true, (Baan)Veld[3, 9], (Baan)Veld[5, 9], false);
            Veld[4, 9].Next = Veld[4, 10];
            Veld[4, 9].Teken = "╩";
            Veld[3, 9].Next = Veld[4, 9];
            Veld[6, 6] = new Wissel(false, (Baan)Veld[5, 6], (Baan)Veld[7, 6],false);
            Veld[6, 6].Next = Veld[6, 7];
            Veld[6, 6].Teken = "╦";
            Veld[7, 6].Next = Veld[6, 6];
            Veld[6, 8] = new Wissel(false, (Baan)Veld[5,8], (Baan)Veld[7,8], true);
            Veld[6, 8].Next = Veld[7, 8];
            Veld[6, 8].Teken = "╦";
            Veld[6, 7].Next = Veld[6, 8];

            Wissels = new Wissel[5];
            Wissels[0] = (Wissel)Veld[4, 3];
            Wissels[1] = (Wissel)Veld[4, 5];
            Wissels[2] = (Wissel)Veld[4, 9];
            Wissels[3] = (Wissel)Veld[6, 6];
            Wissels[4] = (Wissel)Veld[6, 8];
           
        }


    }
}