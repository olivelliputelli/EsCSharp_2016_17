using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es6_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[] {1,2,3,4 };
            //numeri[0] = 1;
            //numeri[1] = 3;
            //numeri[2] = 2;
            //numeri[3] = 1;         

            int somma = 0;
            for (int i = 0; i < numeri.Length; i++)
            {
                somma += numeri[i];
            }
            Console.WriteLine($"Somma = {somma}");
        }
    }
}
