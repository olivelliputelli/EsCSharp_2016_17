using System;
using static System.Console;

namespace SoluzioneEsercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, somma = 0, nNumeri = -1;
            do
            {
                Write("Numero ( 0 per terminare ): ");
                try
                {
                    numero = int.Parse(ReadLine());
                    somma += numero;
                    nNumeri++;
                }
                catch (Exception)
                {
                    WriteLine($"Non è un numero!");
                    continue;                  
                }
            } while (numero != 0);
            WriteLine($"Somma = {somma}");
            WriteLine($"Numero di numeri = {nNumeri}");
            WriteLine($"Media = {(double)somma/(double)nNumeri}");
        }
    }
}
