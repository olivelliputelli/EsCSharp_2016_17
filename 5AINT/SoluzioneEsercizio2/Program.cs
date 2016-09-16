using System;
using static System.Console;

namespace SoluzioneEsercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("--  Sommatoria  --");
            Write("Inizio: ");
            uint inizio = uint.Parse(ReadLine());
            Write("Fine: ");
            uint fine = uint.Parse(ReadLine());
            try
            {
                WriteLine($"Sommatoria da {inizio} a {fine} = {Sommatoria(inizio, fine)}");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }

        /// <summary>
        ///  Returns la sommatoria dei numeri tra due numeri specificati.
        /// </summary>
        /// <param name="inizio">Il valore iniziale dell'indice della sommatoria.</param>
        /// <param name="fine">Il valore finale dell'indice della sommatoria.</param>
        /// <returns>La sommatoria.</returns>
        static ulong Sommatoria(uint inizio, uint fine)
        {
            if (inizio > fine)
                throw new Exception($"Errore: {inizio} > {fine}");

            ulong somma = 0;
            for (uint k = inizio; k <= fine; k++)
            {
                somma += k;
            }
            return somma;
        }

    }
}
