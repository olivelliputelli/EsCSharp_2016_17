using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsNumeroGiorniMese
{
    class Program
    {
        static void Main()
        {
            /* Codice per testare la funzione IsBisestile */
            //Console.WriteLine("Lista anni bisestili");
            //for (int anno = 1900; anno <= 3000; anno++)
            //{
            //    if (IsBisestile(anno)) // IsBisestile(anno) == true
            //        Console.WriteLine(anno);
            //}
            Mese mese;
            int numeroGiorni = 0;
            Console.Write("Mese (in lettere): ");

            /* Metodo con Parse() */
            try
            {
                mese = (Mese)Enum.Parse(typeof(Mese), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine($"Input non valido!");
            }

            /* Metodo con TryParse<>() */
            if (!Enum.TryParse<Mese>(Console.ReadLine(), out mese))
            {
                Console.WriteLine($"Input non valido!");
            }
            else
            {
                switch (mese)
                {
                    case Mese.Gennaio:
                    case Mese.Marzo:
                    case Mese.Maggio:
                    case Mese.Luglio:
                    case Mese.Agosto:
                    case Mese.Ottobre:
                    case Mese.Dicembre:
                        numeroGiorni = 31;
                        break;
                    case Mese.Febbraio:
                        Console.Write("Anno: ");
                        int anno = int.Parse(Console.ReadLine());
                        if (IsBisestile(anno))
                            numeroGiorni = 29;
                        else
                            numeroGiorni = 28;
                        break;
                    case Mese.Aprile:
                    case Mese.Giugno:
                    case Mese.Settembre:
                    case Mese.Novembre:
                        numeroGiorni = 30;
                        break;
                }
                Console.WriteLine("Numero giorni = {0}", numeroGiorni);
            }           
        }

        /// <summary>
        /// Restituisce se un anno è bisestile.
        /// </summary>
        /// <param name="anno">anno compreso tra 1900 e 3000.</param>
        /// <returns>Vero se anno è bisestile.</returns>
        static bool IsBisestile(int anno)
        {
            if (!(anno >= 1900 && anno <= 3000))
                throw new ArgumentOutOfRangeException();

            if ((anno % 4 == 0) && (anno % 100 != 0 || anno % 400 == 0))
            {
                return true;
            }
            return false;
        }
    }
    enum Mese
    {
        Gennaio = 1,
        Febbraio,
        Marzo,
        Aprile,
        Maggio,
        Giugno,
        Luglio,
        Agosto,
        Settembre,
        Ottobre,
        Novembre,
        Dicembre
    }
}
