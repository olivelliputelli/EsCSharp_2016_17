using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaNumeroALettere
{
    class Program
    {
        static void Main(string[] args)
        {
            //int nInCifre = 0;
            //do
            //{
            //    Console.Clear();
            //    Write("Numero: ");
            //    nInCifre = int.Parse(ReadLine());
            //} while (!(nInCifre > 0 && nInCifre < 100));

            for (int i = 1; i < 100; i++)
            {
                WriteLine($"{i} si legge {DaNumeroInCifreANumeroInLettere(i)}");
            }  
        }

        static string DaNumeroInCifreANumeroInLettere(int nInCifre)
        {
            if (!(nInCifre > 0 && nInCifre < 100))
                throw new ArgumentOutOfRangeException(); 
            
            int decine = nInCifre / 10;
            int unita = nInCifre % 10;
            string numeroInLettere = "";

            switch (decine)
            {
                case 0:
                    numeroInLettere = "";
                    break;
                case 1:
                    switch (unita)
                    {
                        case 0:
                            numeroInLettere += "dieci";
                            break;
                        case 1:
                            numeroInLettere += "undici";
                            break;
                        case 2:
                            numeroInLettere += "dodici";
                            break;
                        case 3:
                            numeroInLettere += "tredici";
                            break;
                        case 4:
                            numeroInLettere += "quattordici";
                            break;
                        case 5:
                            numeroInLettere += "quindici";
                            break;
                        case 6:
                            numeroInLettere += "sedici";
                            break;
                        case 7:
                            numeroInLettere += "diciassette";
                            break;
                        case 8:
                            numeroInLettere += "diciotto";
                            break;
                        case 9:
                            numeroInLettere += "diciannove";
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    numeroInLettere += "venti";
                    break;
                case 3:
                    numeroInLettere += "trenta";
                    break;
                case 4:
                    numeroInLettere += "quaranta";
                    break;
                case 5:
                    numeroInLettere += "cinquanta";
                    break;
                case 6:
                    numeroInLettere += "sessanta";
                    break;
                case 7:
                    numeroInLettere += "settanta";
                    break;
                case 8:
                    numeroInLettere += "ottanta";
                    break;
                case 9:
                    numeroInLettere += "novanta";
                    break;
            }
            if (decine != 1)
            {
                switch (unita)
                {
                    case 1:
                        if (decine != 0)
                            numeroInLettere = numeroInLettere.Substring(0, numeroInLettere.Length - 1);
                        numeroInLettere += "uno";
                        break;
                    case 2:
                        numeroInLettere += "due";
                        break;
                    case 3:
                        numeroInLettere += "tre";
                        break;
                    case 4:
                        numeroInLettere += "quattro";
                        break;
                    case 5:
                        numeroInLettere += "cinque";
                        break;
                    case 6:
                        numeroInLettere += "sei";
                        break;
                    case 7:
                        numeroInLettere += "sette";
                        break;
                    case 8:
                        if (decine != 0)
                            numeroInLettere = numeroInLettere.Substring(0, numeroInLettere.Length - 1);
                        numeroInLettere += "otto";
                        break;
                    case 9:
                        numeroInLettere += "nove";
                        break;
                    default:
                        break;
                }
            }
            return numeroInLettere;
        }


    }
}
