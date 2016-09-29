using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsClassePersona.Model;
using System.ComponentModel.DataAnnotations;

namespace EsClassePersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            Console.Write("Cognome: ");
            p1.Cognome = Console.ReadLine();

            Console.Write("Nato il: ");
            p1.DataDiNascita = DateTime.Parse(Console.ReadLine());

            Console.Write("Colore occhi: ");
            ColoreOcchi coloreOcchi = ColoreOcchi.NonDichiarato;
            if (Enum.TryParse<ColoreOcchi>(Console.ReadLine(), out coloreOcchi))
                p1.Occhi = coloreOcchi;

            Console.Write("Altezza (cm): ");
            p1.Altezza = int.Parse(Console.ReadLine());

            Console.Write("Codice fiscale (1AB): ");
            p1.CodiceFiscale = Console.ReadLine();

            var listaProblemi = new List<ValidationResult>();
            var vc = new ValidationContext(p1);
            var isValid = Validator.TryValidateObject(p1, vc, listaProblemi, true);
            if (isValid)
            {
                Console.WriteLine(p1);
            }
            else
            {
                foreach (var problema in listaProblemi)
                {
                    Console.WriteLine(problema.ErrorMessage);
                }
            }

        }
    }
}
