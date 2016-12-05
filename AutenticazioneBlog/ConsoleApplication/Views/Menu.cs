using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication.Views
{
    public class Menu
    {
        
        public static void MenuAdmin()
        {
            string scelta = "";
            do
            {
                Clear();
                WriteLine("****  A  M  M  I  N  I  S  T  R  A Z  I  O  N  E    *************");
                WriteLine("NU - Registra Nuovo Utente");
                WriteLine("LU - Lista Utenti");
                WriteLine("AU - Aggiurnare Utente");
                WriteLine("CU - Cancellare Utente");

                WriteLine("ARU - Assegnazione ruolo a utente");
                WriteLine("EX - Menu precedente");

                Write("?");
                scelta = ReadLine().ToUpper();
                switch (scelta)
                {
                    case "NU":
                        //ModuloNuovoUtente();
                        break;

                    case "AD":
                        //MenuAmministrazione();
                        break;

                    case "ARU":
                        //AssegnazioneRuoloUtente();
                        break;
                    default:
                        break;
                }
            } while (scelta.ToUpper() != "EX");
        }

        public static void MenuBlogger()
        {
            string scelta = "";
            do
            {
                Clear();
                WriteLine("****  A  M  M  I  N  I  S  T  R  A Z  I  O  N  E    *************");
                WriteLine("NU - Registra Nuovo Utente");
                WriteLine("LU - Lista Utenti");
                WriteLine("AU - Aggiurnare Utente");
                WriteLine("CU - Cancellare Utente");

                WriteLine("ARU - Assegnazione ruolo a utente");
                WriteLine("EX - Menu precedente");

                Write("?");
                scelta = ReadLine().ToUpper();
                switch (scelta)
                {
                    case "NU":
                        //ModuloNuovoUtente();
                        break;

                    case "AD":
                        //MenuAmministrazione();
                        break;

                    case "ARU":
                        //AssegnazioneRuoloUtente();
                        break;
                    default:
                        break;
                }
            } while (scelta.ToUpper() != "EX");
        }
    }
}
