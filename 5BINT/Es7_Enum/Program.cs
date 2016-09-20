using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es7_Enum
{
    class Enumeativi
    {
        static void Main(string[] args)
        {
            var lista = new List<Colore>();

            Colore c;
            Console.Write("Colore: ");

            try
            {
                c = (Colore)Enum.Parse(typeof(Colore), Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            

            if (!Enum.TryParse<Colore>(Console.ReadLine(), out c))
            {
                Console.WriteLine("Non è un colore valido!");
            }
            else
            {
                switch (c)
                {
                    case Colore.Rosso:
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case Colore.Verde:
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case Colore.Blu:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case Colore.Giallo:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        break;
                    case Colore.VerdeChiaro:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                }
                Console.WriteLine("Ciao Mondo!!!");
            }
        }
    }


    enum Colore
    {
        Rosso = 1,
        Verde,
        Blu,
        Giallo,
        VerdeChiaro
    }

}
