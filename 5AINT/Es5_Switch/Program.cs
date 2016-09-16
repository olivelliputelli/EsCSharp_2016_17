using System;
using static System.Console;

namespace Es5_Switch
{
    class Esercizio5
    {
        static void Main(string[] args)
        {
            for (int voto = 0; voto < 13; voto++)
            {
                WriteLine($"Voto: {voto} ( {Giudizio(voto)} )");
            }
        }

        static string Giudizio(int voto)
        {
            string giudizio;
            switch (voto)
            {
                case 1:
                case 2:
                    giudizio = "Gravemente scarso!";
                    break;
                case 3:
                case 4:
                    giudizio = "Scarso!";
                    break;
                case 5:
                    giudizio = "Quasi Suff.!!";
                    break;
                case 6:
                    giudizio = "Sufficiente!";
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
                    giudizio = "NON voto valido!!";
                    break;
            }
            return giudizio;
        }


    }
}
