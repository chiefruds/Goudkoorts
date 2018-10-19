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
            Console.WriteLine("#  --         =    een rangeerterrein       #");
            Console.WriteLine("#############################################");
            Console.ReadLine();
        }

        public void PrintField(String[,] StringArray)
        {
            for(int i = 0; i < StringArray.GetLength(0); i++)
            {
                for(int j = 0; j < StringArray.GetLength(1); j++)
                {
                    if(StringArray[i,j] == null)
                    {
                        Console.Write(" ");
                    } else
                    {
                        Console.Write(StringArray[i, j]);
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}