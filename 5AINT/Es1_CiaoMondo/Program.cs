using System;
using static System.Console;

namespace Es1_CiaoMondo
{
    class Program
    {
        /// <summary>
        /// Io sono un commento che viene usato per 
        /// generare la documentazione in automatico.
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            /* Io sono un commento
             * su più righe                         
            */
            Write("Nome: ");
            string nome = ReadLine(); // anche io sono un commento

            WriteLine($"Ciao {nome}!!");
        }
    }
}
