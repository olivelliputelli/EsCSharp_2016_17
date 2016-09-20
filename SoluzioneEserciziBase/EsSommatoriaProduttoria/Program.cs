using System;

namespace EsSommatoriaProduttoria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                uint inizio = 0; uint fine = 0;
                Console.Write("Inizio: ");
                inizio = uint.Parse(Console.ReadLine());
                Console.Write("Fine: ");
                fine = uint.Parse(Console.ReadLine());
                Console.WriteLine($"Sommatoria dei numeri da {inizio} a fine {fine} = {Sommatoria(inizio, fine)}");
                Console.WriteLine($"Produttoria dei numeri da {inizio} a fine {fine} = {Produttoria(inizio, fine)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
        /// <summary>
        /// Restituisce la sommatoria dei numeri tra due numeri specificati 
        /// oppure 0 se il primo numero è maggiore del secondo.
        /// </summary>
        /// <param name="inizio">Il valore iniziale dell'indice della sommatoria.</param>
        /// <param name="fine">Il valore finale dell'indice della sommatoria.</param>
        /// <returns>La sommatoria.</returns>
        static ulong Sommatoria(uint inizio, uint fine)
        {
            ulong somma = 0;
            for (ulong i = inizio; i <= fine; i++)
            {
                somma += i;
            }
            return somma;
        }

        static ulong Produttoria(uint inizio, uint fine)
        {
            ulong prodotto = 1;
            for (ulong i = inizio; i <= fine; i++)
            {
                prodotto *= i;
            }
            return prodotto;
        }

    }
}
