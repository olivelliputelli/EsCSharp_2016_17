using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsClassePersona.Model;
using System.ComponentModel.DataAnnotations;
using static System.Console;

namespace EsClassePersona
{
    class Program
    {
        public static List<Persona> listaPersone = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            InitializeLista(); // Feed la lista.
            string scelta = "";
            do
            {                
                Console.Clear();
                WriteLine(" ----- D A T A B A S E   P E R S O N E (CRUD) -----");
                WriteLine("Create - Aggiungi nuova persona.");
                WriteLine("Read -Visualizza la lista di persone.");
                WriteLine("Update -Aggiorna una persona.");
                WriteLine("Delete - Camcella una persona.");
                WriteLine("T - Termina programma.");
                Write("?? ");
                scelta = ReadLine();
                Console.Clear();
                switch (scelta.ToUpper())
                {
                    case "T":
                        break;
                    case "CREATE":
                        listaPersone.Add(RiempiPersona());
                        break;
                    case "READ":
                        WriteLine("----- READ -----");
                        foreach (var persona in listaPersone)
                        {
                            WriteLine(persona.ToString());
                        }
                        break;
                    case "UPDATE":
                        WriteLine("----- UPDATE -----");
                        break;
                    case "DELETE":
                        WriteLine("----- DELETE -----");
                        Write("Cognome da cancellare: ");
                        string cognome = ReadLine();
                        //var personaDacancellare = listaPersone.SingleOrDefault(p => p.Cognome == cognome);
                        //if (personaDacancellare == null)
                        //{
                        //    WriteLine("Non ho trovato nessuno!!");
                        //    break;
                        //}
                        //listaPersone.Remove(personaDacancellare);

                        int numeroElementiRimossi = listaPersone.RemoveAll(p => p.Cognome == cognome);

                        WriteLine($"Rimossi: {numeroElementiRimossi} elementi");
                        break;
                    default:
                        WriteLine("Comando non valido!!!");
                        break;
                }
                ReadKey();
            } while (scelta.ToUpper() != "T");

            WriteLine("FINE!!");
        }

        public static Persona RiempiPersona()
        {
            bool isValid = false;
            Persona persona = new Persona();
            do
            {
                Console.Write("Cognome: ");
                persona.Cognome = Console.ReadLine();

                Console.Write("Nato il: ");
                persona.DataDiNascita = DateTime.Parse(Console.ReadLine());

                Console.Write("Colore occhi: ");
                ColoreOcchi coloreOcchi = ColoreOcchi.NonDichiarato;
                if (Enum.TryParse<ColoreOcchi>(Console.ReadLine(), out coloreOcchi))
                    persona.Occhi = coloreOcchi;

                Console.Write("Altezza (cm): ");
                persona.Altezza = int.Parse(Console.ReadLine());

                Console.Write("Codice fiscale (1AB): ");
                persona.CodiceFiscale = Console.ReadLine();

                var listaProblemi = new List<ValidationResult>();
                var vc = new ValidationContext(persona);

                isValid = Validator.TryValidateObject(persona, vc, listaProblemi, true);

                foreach (var problema in listaProblemi)
                {
                    Console.WriteLine(problema.ErrorMessage);
                }
            } while (!isValid);
            WriteLine(persona);
            return persona;
        }

        public static void InitializeLista()
        {
            listaPersone = new List<Persona>()
            {
                new Persona() { Cognome = "Rossi", DataDiNascita = new DateTime(2010, 1, 2),Altezza = 123, CodiceFiscale = "1AB", Occhi = ColoreOcchi.Azzurri },
                new Persona() { Cognome = "Bianchi", DataDiNascita = new DateTime(1970, 1, 2),Altezza = 165, CodiceFiscale = "1AB", Occhi = ColoreOcchi.Blu },
                new Persona() { Cognome = "Gialli", DataDiNascita = new DateTime(1990, 1, 2),Altezza = 145, CodiceFiscale = "1AB", Occhi = ColoreOcchi.Neri },
                new Persona() { Cognome = "Rossi", DataDiNascita = new DateTime(1990, 5, 2),Altezza = 17, CodiceFiscale = "1AB", Occhi = ColoreOcchi.NonDichiarato},
                new Persona() { Cognome = "Verdi", DataDiNascita = new DateTime(1992, 1, 2),Altezza = 23, CodiceFiscale = "1AB", Occhi = ColoreOcchi.Azzurri },
                new Persona() { Cognome = "Rossini", DataDiNascita = new DateTime(1987, 1, 2),Altezza = 13, CodiceFiscale = "1AB", Occhi = ColoreOcchi.Blu },
                new Persona() { Cognome = "LArice", DataDiNascita= DateTime.Now.AddYears(-6), Altezza=178, CodiceFiscale="1SA", Occhi = ColoreOcchi.Verdi  }
            };

            


        }

    }


}
