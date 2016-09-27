using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Es1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2016, 09, 26, 12,12,12);

            DateTime d2 = DateTime.Now;

            DateTime compleannoTobina = DateTime.Parse("2014/01/02");
            TimeSpan anniTobina = DateTime.Now.Subtract(compleannoTobina);

            Console.WriteLine(anniTobina);
        
           
 
        }
    }
}
