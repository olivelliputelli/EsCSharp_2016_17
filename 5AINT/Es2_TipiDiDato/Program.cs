using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es2_TipiDiDato
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabili e tipi di dato
            double numero = 1.3E-25;

            int n1 = 10;
            n1 = n1 + 2;
            string nome = "PIppo";
            nome = nome + "!!!!!";
            bool isNero = true; // &&, ||, !

            var cognome = "Rossi";
            var numero2 = 23.0D;

        }
        public static int Massimo(int n1, int n2)
        {
            return (n1 < n2) ? n2 : n1;
        }

    }
}
