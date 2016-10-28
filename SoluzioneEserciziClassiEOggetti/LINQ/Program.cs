using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaMacchine = FeedListaMacchine();


            var listaMarcaModello = listaMacchine.Select(m => new {m.Marca, m.Modello });

            foreach (var m in listaMarcaModello)
            {
                Console.WriteLine($"{m.Marca} {m.Modello}");
            }


            //listaMacchine
            //    .Where(m => m.Marca == "Fiat" || m.Marca == "BMW").ToList()
            //    .ForEach(m => Console.WriteLine(m));

            //listaMacchine.SingleOrDefault(m => m.MacchinaId == 8).Prezzo = 100D;
            //listaMacchine.Remove(listaMacchine.SingleOrDefault(m => m.MacchinaId == 5));

            //listaMacchine.ForEach(m => m.Prezzo *= 1.11);

            //listaMacchine
            //    .OrderByDescending(m => m.Prezzo)
            //    .ToList()
            //    .ForEach(m => Console.WriteLine(m.ToString()));





            // LINQ sintassi query in Informatica
            //var fiat = from m in listaMacchine
            //           where m.Marca == "Fiat"
            //           orderby m.Anno
            //           select m;


            //var bmws = from macchina in listaMacchine
            //           where macchina.Marca == "Fiat"
            //           orderby macchina.Anno ascending
            //           select macchina;

            // LINQ sintassi Metodo/Funzionale in Tecnologie con Lambda Expression
            //var bmws = listaMacchine
            //    .Where(m => m.Marca == "BMW")
            //    .OrderByDescending(m => m.Prezzo);




            //var fiat = listaMacchine.Where(m => m.Marca == "Fiat")
            //    .OrderByDescending(m => m.Modello)
            //    .ToList(); // Lambda expression

            //Console.WriteLine(listaMacchine.Where(m => m.Marca=="BMW").ToList().TrueForAll(p => p.Anno > 2000));

            //foreach (var m in bmws)
            //{
            //    Console.WriteLine(m.ToString());
            //}


            //listaMacchine.ForEach(m => m.Prezzo += -41);

            //listaMacchine
            //    .Where(m => m.Marca=="Fiat")
            //    .OrderBy(m => m.Prezzo)
            //    .ToList()
            //    .ForEach(m => Console.WriteLine(m));

            // Console.WriteLine(listaMacchine.Exists(m => m.Marca == "Maserati"));
            string aa = "AAA";
            string dd = "sdgreh";
            double soldi = 12D;
            Console.WriteLine($"Ciao {aa}, e tu {dd} Soldi = {soldi:P}");

        }

        private static List<Macchina> FeedListaMacchine()
        {
            List<Macchina> listaMacchine = new List<Macchina>()
            {
                new Macchina() { MacchinaId = 1, Marca="Fiat", Modello="Panda", Anno=2001, Prezzo=4500D  },
                new Macchina() { MacchinaId = 2, Marca="BMW", Modello="M5", Anno=2001, Prezzo=1230D  },
                new Macchina() { MacchinaId = 3, Marca="Fiat", Modello="Uno", Anno=2000, Prezzo = 124D  },
                new Macchina() { MacchinaId = 4, Marca="Fiat", Modello="Panda", Anno=1990, Prezzo= 1000D  },
                new Macchina() { MacchinaId = 5, Marca="Audi", Modello="A4", Anno=2000,Prezzo= 123000D  },
                new Macchina() { MacchinaId = 6, Marca="Ferrari", Modello="Enzo", Anno=2000, Prezzo = 300000D  },
                 new Macchina() { MacchinaId = 8, Marca="BMW", Modello="M3", Anno=2001, Prezzo=12230D  },
                  new Macchina() { MacchinaId = 9, Marca="BMW", Modello="M5", Anno=2011, Prezzo=1830D  },
                new Macchina() { MacchinaId = 7, Marca="Fiat", Modello="Cinquecento", Anno=2004, Prezzo= 1500D }
            };
            return listaMacchine;
        }



    }

    

}
