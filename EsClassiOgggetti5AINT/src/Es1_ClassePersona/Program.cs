using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Es1_ClassePersona
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Console.Write("Cognome: ");
            p1.Cognome = Console.ReadLine();
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Anno di nascita: ");
            p1.AnnoDiNascita = int.Parse(Console.ReadLine());
            Console.Write("Classe frequentata: ");
            p1.ClasseFrequentata = Console.ReadLine();
            Console.Write("Colore occhi: ");
            // In altri tipi di applicazioni avrei una scelta a tendina.
            ColoreOcchi occhi = ColoreOcchi.NonSpecificato;
            if(Enum.TryParse<ColoreOcchi>(Console.ReadLine(), out occhi))
                p1.Occhi = occhi;

            var listaProblemi = new List<ValidationResult>();
            var vc = new ValidationContext(p1);
            var isValid = Validator.TryValidateObject(p1, vc, listaProblemi, true);
            if (isValid)
            {
                Console.WriteLine("Tutto OK");
            }
            else
                foreach (var item in listaProblemi)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
        }
    }
}
