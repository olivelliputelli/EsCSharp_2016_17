using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es7_Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string strColore;
                Console.Write("Che colore vuoi? ");
                strColore = Console.ReadLine();
                Colore colore;
                colore = (Colore)Enum.Parse(typeof(Colore), strColore);

                switch (colore)
                {
                    case Colore.Rosso:
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case Colore.Verde:
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case Colore.Giallo:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        break;
                    case Colore.Bianco:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case Colore.Nero:
                        break;
                }
      
                Console.WriteLine("Ciao Mondo!!!!!");
            }
            catch (Exception)
            {
                Console.WriteLine("Un colore valido!!!!");
            }

        }
    }

    enum Colore
    {
        Rosso = 1,
        Verde,
        Giallo,
        Bianco,
        Nero
    }
    }

}
