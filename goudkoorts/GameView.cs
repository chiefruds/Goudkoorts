using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace goudkoorts
{
    public class GameView
    {
        public void Start()
        {
            Console.WriteLine("Welkom bij het spel goudkoorts!");
            Console.WriteLine("de spelregels staan hieronder uitgelegd.");
            Console.WriteLine("#############################################");
            Console.WriteLine("# <   >       =     een leeg schip          #");
            Console.WriteLine("# <o  >       =     een halfvol schip       #");
            Console.WriteLine("# <ooo>       =     een vol schip           #");
            Console.WriteLine("#  ~          =     water                   #");
            Console.WriteLine("#  _          =     een baan                #");
            Console.WriteLine("#  o          =     een lege kar            #");
            Console.WriteLine("#  Ø          =     een vole kar            #");
            Console.WriteLine("#  k          =     een kade                #");
            Console.WriteLine("#  X          =     een loods               #");
            Console.WriteLine("#  /          =     een wissel              #");
            Console.WriteLine("#  \\         =     een wissel              #");
            Console.WriteLine("#  --          =    een rangeerterrein      #");
            Console.WriteLine("#############################################");
            Console.ReadLine();
        }
    }
}