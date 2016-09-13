using System;
using static System.Console;

namespace Es1_CiaoMondo
{
    class Program
    {
        /// <summary>
        /// Questo è un commento per la documentazione automatica..
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*
             *Questo è un commento 
             * su più righe             
             */
            Write("Nome: ");
            string nome = ReadLine(); // anche io sono un commento su una riga

            Console.WriteLine($"Ciao {nome}!!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int MassimoTraDueNumeri(int a, int b)
        {
            return a;
        }
    }
}
