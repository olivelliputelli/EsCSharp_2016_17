using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es5_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var numeri = new StreamReader(@"Data\Numeri.txt"))
            {
                while (numeri.Peek() >= 0)
                {
                    Console.WriteLine(numeri.ReadLine());
                }
            }
        }
    }
}
