using System;
using System.IO;
namespace Ripasso_19_09
{
    class Esercizio
    {
        static void Main(string[] args)
        {
            //UsoFile();
            GestioneEccezioni();
        }

        static void GestioneEccezioni()
        {
            try
            {
                int numeratore = 0, denominatore = 0, quoziente = 0;
                Console.Write("Numeratore: ");
                numeratore = int.Parse(Console.ReadLine());
                Console.Write("Denominatore: ");
                denominatore = int.Parse(Console.ReadLine());
                quoziente = numeratore / denominatore;
                Console.WriteLine($"Quoziente = {quoziente}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("NOON SI DIVIDE PER ZERO!!!!!!");
            }            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("FIIIIIIIIIIIIIIIIIIIINNNNNNNNNEEEEE!!!!");
            }
        }

        static void UsoFile()
        {
            int somma = 0, numero = 0;
            try
            {
                using (var sr = new StreamReader(@"Dati\Numeri.txt"))
                {

                    while (sr.Peek() >= 0)
                    {
                        if (int.TryParse(sr.ReadLine(), out numero))
                        {
                            somma += numero; // somma = somma + numero
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            try
            {
                using (var sw = new StreamWriter(@"C:\Users\paolo\Desktop\Numeri.txt", true))
                {
                    sw.WriteLine();
                    sw.WriteLine("-------- OUTPUT -----------");
                    sw.WriteLine($"Somma = {somma}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

    }
}
