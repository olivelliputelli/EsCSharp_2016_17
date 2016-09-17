using System;
using System.IO;

namespace SoluzioneEsercizio1ConFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"Data\Numeri.txt"))
            {
               Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
