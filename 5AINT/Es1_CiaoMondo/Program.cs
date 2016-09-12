using System;
using static System.Console;

namespace Es1_CiaoMondo
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Nome: ");
            string nome = ReadLine();

            Console.WriteLine($"Ciao {nome}!!");
        }
    }
}
