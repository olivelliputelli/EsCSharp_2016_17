using System;
using static System.Console;

namespace Es4_CicliFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Inizio: ");
            int inizio = Convert.ToInt16(ReadLine());

            Write("Fine: ");
            int fine = Convert.ToInt16(ReadLine());

            Write("Passo: ");
            int passo = Convert.ToInt16(ReadLine());

            for (int i = inizio; i < fine; i += passo)
            {
                Console.WriteLine(i);
            } 
        }
    }
}
