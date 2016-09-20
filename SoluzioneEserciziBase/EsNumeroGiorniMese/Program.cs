using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsNumeroGiorniMese
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista anni bisestili");
            for (int anno = 1900; anno <= 3000; anno++)
            {
                if (IsBisestile(anno)) // IsBisestile(anno) == true
                    Console.WriteLine(anno);
            }
        }

        static bool IsBisestile(int anno)
        {
            if (!(anno >= 1900 && anno <= 3000))
                throw new ArgumentOutOfRangeException();
            
            if((anno % 4 == 0) && (anno % 100 != 0 || anno % 400 == 0))
            {
                return true;
            }
            return false;
        }
    }
}
