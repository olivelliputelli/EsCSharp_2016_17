using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            Console.Write("Codice Fiscale: ");
            p1.CodiceFiscale = Console.ReadLine();


            Console.Write("Cognome: ");
            p1.Cognome = Console.ReadLine();

            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Anno di nascita: ");
            p1.AnnoDinascita = int.Parse(Console.ReadLine());

            Console.Write("Occhi: ");
            ColoreOcchi occhi;
            if (Enum.TryParse<ColoreOcchi>(Console.ReadLine(), out occhi))
                p1.Occhi = occhi;

            var listaProblemi = new List<ValidationResult>();
            var vc = new ValidationContext(p1);
            var isValid = Validator.TryValidateObject(p1, vc, listaProblemi, true);
            if (isValid)
            {
                using (var db = new PersoneContext())
                {
                    db.Persone.Add(p1);
                    var count = db.SaveChanges();
                    Console.WriteLine("{0} persone aggiunte", count);
                }

                Console.WriteLine(p1.ToString());
            }
            else
                foreach (var problema in listaProblemi)
                {
                    Console.WriteLine(problema.ErrorMessage);
                }
            using (var db = new PersoneContext())
            {
                Console.WriteLine();
                Console.WriteLine("Persone registrate: ");
                foreach (var persona in db.Persone)
                {
                    Console.WriteLine(persona.ToString());
                }
            }

        }
    }
}
