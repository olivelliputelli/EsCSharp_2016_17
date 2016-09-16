using System;
using static System.Console;

namespace Es6_Switch
{
    class Es6
    {
        static void Main(string[] args)
        {
           
            for (byte voto = 0; voto < 15; voto++)
            {
                WriteLine($"{voto} --> {Giudizio(voto)}");
            }
        }
        /// <summary>
        /// Returns il giudizio a partire dal voto.
        /// </summary>
        /// <param name="voto">Numero che rappresenta il voto.</param>
        /// <returns>Il giudizio.</returns>
        static string Giudizio(byte voto)
        {
            string giudizio;
            switch (voto)
            {
                case 1:
                case 2:
                    giudizio = "Grav. Insuf.!";
                    break;
                case 3:
                case 4:
                    giudizio = "Insuf.!";
                    break;
                case 5:
                    giudizio = "Quasi Suf.!";
                    break;
                case 6:
                    giudizio = "Suf.!";
                    break;
                case 7:
                case 8:
                    giudizio = "Buono!";
                    break;
                case 9:
                case 10:
                    giudizio = "Ottimo!";
                    break;
                default:
                    giudizio = $"{voto} Non è un voto!";
                    break;
            }        
            return giudizio;
        }



    }
}
