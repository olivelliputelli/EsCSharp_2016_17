using System;
using System.IO;
using static System.Console;

namespace Es5_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long somma = 0;
                int c =0, nNumeri =1;
                long nPrimo, n;
                using (var sr = new StreamReader(@"Data\Numeri.txt"))
                {
                    nPrimo = long.Parse((sr.ReadLine()));

                    while (sr.Peek() >= 0)
                    {
                        try
                        {
                            n= long.Parse((sr.ReadLine()));
                            somma += n;
                            nNumeri++;
                            if(n != nPrimo) c++;                                
                        }
                        catch (Exception)
                        {}                        
                    }                 
                }
                using (StreamWriter sw = new StreamWriter(@"Data\Numeri.txt", true))
                {
                    sw.WriteLine();
                    sw.WriteLine("----------------");
                    sw.WriteLine($"Somma = {somma}");
                    double media = (double)somma / (double)nNumeri;
                    sw.WriteLine($"Media = {media}");
                    sw.WriteLine($"Numero numeri diversi da {nPrimo} = {c}");
                }                
            }
            catch (FileNotFoundException ex)
            {
                WriteLine($"{ex.FileName} non esistente!");
            }
            catch (DirectoryNotFoundException)
            {
                WriteLine("Directory non esistente!");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

        }
    }
}
