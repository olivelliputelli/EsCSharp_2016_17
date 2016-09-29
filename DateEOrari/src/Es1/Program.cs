using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Es1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //DateTime d1 = new DateTime(2016, 09, 26, 12,12,12);

            //DateTime d2 = DateTime.Now;

            //DateTime compleannoTobina = DateTime.Parse("2014/01/02");
            //TimeSpan anniTobina = DateTime.Now.Subtract(compleannoTobina);

            //Console.WriteLine(anniTobina);



            //var currentTime = DateTime.Now; // current time
            //var today = DateTime.Today; // current date - time is midnight
            //var someDate = new DateTime(2016, 7, 1); // 1 July 2016, midnight
            //var someMoment = new DateTime(2016, 7, 1, 8, 0, 0); // 1 July 2016, 08:00.00
            //var tomorrow = DateTime.Today.AddDays(1);
            //var yesterday = DateTime.Today.AddDays(-1);
            //var someDay = DateTime.Parse("7/1/2016");


            var compleannoTobina = DateTime.Parse("30/09/2013");
            int numeroAnni = DateTime.Now.Year - compleannoTobina.Year;
            if (compleannoTobina.DayOfYear - DateTime.Now.DayOfYear >= 0)
                numeroAnni--;


            Console.WriteLine($"Adesso: {DateTime.Now.ToString("dd MMMM yyyy hh:mm .. K")}");
            Console.WriteLine($"Anni: {numeroAnni}");



        }
    }

    public class Rettangolo
    {
        [Range(0,double.MaxValue, ErrorMessage ="Valore di {0} non valido; deve essere compreso tra {1} e {2}")]
        public double Base { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Valore di {0} non valido; deve essere compreso tra {1} e {2}")]
        public double Altezza { get; set; }

        // Area 
        // Perimetro

    }

}
