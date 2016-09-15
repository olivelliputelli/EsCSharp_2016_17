using System;
using static System.Console;

namespace Es4_CicliFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Inizio: ");
            int inizio = Convert.ToInt32(ReadLine());
            Write("Fine: ");
            int fine = Convert.ToInt32(ReadLine());
            Write("Passo: ");
            int passo = Convert.ToInt32(ReadLine());
            try
            {
                StampaNumeri(inizio, fine, passo);
            }
            catch (Exception e)
            {
                WriteLine($"Errore!! {e.Message}");
            }            
        }

        static void StampaNumeri(int inizio, int fine, int passo)
        {
            if(inizio > fine || passo <= 0)
            {
                throw new Exception("vsdgdr geg");
            }

            for (int contatore = inizio; contatore < fine; contatore+=passo)
            {
                if (contatore == 7)
                {
                    WriteLine("Sette");
                    break;
                }
                WriteLine(contatore);
            }                        
        }
    }
}
