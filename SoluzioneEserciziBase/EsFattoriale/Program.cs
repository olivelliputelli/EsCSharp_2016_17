using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Matematica.SpostaTorre(4, 1, 3, 2);
            //Console.WriteLine("Produttoria = " + FunzioniUtili.Matematica.Produttoria(1, 5));
        }
    }
}
