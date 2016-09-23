using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieFunzioniMatematica
{
    public static class Matematica
    {
        public const int MIA_COSTANTE = 12;
        public static ulong Sommatoria(uint inizio, uint fine)
        {
            ulong somma = 0;
            for (ulong i = inizio; i <= fine; i++)
            {
                somma += i;
            }
            return somma;
        }
        public static ulong Produttoria(uint inizio, uint fine)
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
