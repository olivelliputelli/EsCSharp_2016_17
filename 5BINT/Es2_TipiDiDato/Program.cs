using System;
using static System.Console;

namespace Es2_TipiDiDato
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 10.03D;
            int n1 = 12;
            float n3 = 23.0f;
            int n4 = 9;
            double n5 = 5.1D;

            n4 = (int)n5; // casting

            n5 = n4;
            numero = Convert.ToDouble(ReadLine());
        }
    }
}
