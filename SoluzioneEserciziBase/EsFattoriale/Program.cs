using System;

namespace EsFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("N: ");
            //byte n = byte.Parse(Console.ReadLine());
            //for (byte i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i + " --> " + Matematica.Fattoriale(i) + " ---> " + Matematica.FattorialeRic(i));
            //}

            //Matematica.SpostaTorre(4, 1, 3, 2);
            //Console.WriteLine("Produttoria = " + FunzioniUtili.Matematica.Produttoria(1, 5));

            Console.WriteLine("5 sopra 3 = " + Matematica.CoefficienteBinomiale(5, 3));
        }
    }
}
