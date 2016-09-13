using System;
using static System.Console;

namespace Es3_StruttureDiControllo
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numeri = { 2, 6, 7, -2 };
            WriteLine($"SommaFor = {SommaFor(numeri)} \nSommaForeach = {SommaForeach(numeri)}");
            ReadKey();
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Massimo(int n1, int n2)
        {
            
            return (n1 < n2) ? n2 : n1;
        }

        public static double SommaForeach(double[] numeri)
        {
            double somma = 0.0D;
            foreach (var n in numeri)
            {
                somma += n;
            }
            return somma;
        }
        public static double SommaFor(double[] numeri)
        {
            double somma = 0.0D;
            for (int i = 0; i < numeri.Length; i++)
            {
                somma += numeri[i];
            }
            return somma;
        }

        // Pre condizionale
     //   while (true)
	    //{
            
	    //}

        //Post condizionale
     //   do
	    //{

	    //} while (true);



    }
}
