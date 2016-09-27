using System.ComponentModel.DataAnnotations;
using System;

namespace Persone.Model
{
    public class Persona
    {
        // Campi/Attributi 
        // Costanti
        // Property
        // Metodi
        // Costruttori
        // Methods, properties, fields, events, delegates 
        // and nested classes go here.

        public int PersonaId { get; set; }

        [RegularExpression(@"[1-5][A-F]", ErrorMessage = "Il {0} non e' valida!")]
        public string CodiceFiscale { get; set; }

        [Required(ErrorMessage = "Il {0} e' richiesto.")]
        [MaxLength(50, ErrorMessage = "La lunghezza del {0} deve essere minore di {1}.")]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }

        [Range(1900, 2150, ErrorMessage = "{0} compreso tra {1} e {2}")]
        public int AnnoDinascita { get; set; }

        public ColoreOcchi Occhi { get; set; }


        public int Eta
        { 
            get {
                return DateTime.Now.Year - this.AnnoDinascita ;
            }
        }


        public override string ToString()
        {
            return $"{this.Nome} {this.Cognome} ({this.AnnoDinascita})";
        }
    }

    public enum ColoreOcchi
    {
        NonSpecificato = 1,
        Nero,
        Blu,
        Verde,
        Azzurro
    }
}
