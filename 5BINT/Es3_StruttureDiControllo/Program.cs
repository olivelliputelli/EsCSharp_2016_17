using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es3_StruttureDiControllo
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Cerchio();
            c1.Raggio = 2;
            c1.Altezza = 23;
           

        }

        static double MassimoTraDueNumeri(double n1, double n2)
        {
            return (n1 < n2) ? n2 : n1;
        }

        static double SommaNumeriForeach(double[] numeri)
        {
            double somma = 0D;
            foreach(var numero in numeri)
                somma += numero;
            return somma;
        }

        static double SommaNumeriFor(double[] numeri)
        {
            double somma = 0D;
            for (var i = 0; i< numeri.Length; i++)
                somma += numeri[i];
            return somma;
        }


    }
}
