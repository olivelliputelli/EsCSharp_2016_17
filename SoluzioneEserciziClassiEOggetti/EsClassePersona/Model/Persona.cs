using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsClassePersona.Model
{
    /// <summary>
    /// Non ho inserito attributi con le stesse caratteristiche per non ripetermi.
    /// </summary>
    class Persona
    {
        public int PersonaId { get; set; } // Conventions over configurations: Identificatore univoco

        [Required(ErrorMessage = "Il {0} e' richiesto.")]
        [MaxLength(60, ErrorMessage = "La lunghezza del {0} deve essere minore di {1}.")]
        public string Cognome { get; set; }

        public DateTime DataDiNascita { get; set; }

        public ColoreOcchi Occhi { get; set; }

        [Range(10,250, ErrorMessage = "{0} deve essere tra {1} e {2} cm.")]
        public int Altezza { get; set; } //in centimetri. es. 182.

        [RegularExpression(@"[1-5][A-Z][A-F]", ErrorMessage = "Il {0} non e' valido!")]
        public string CodiceFiscale { get; set; } // Per semplicità solo 3 caratteri. es. 1AD 

        public int Eta
        {
            get {
                int numeroAnni = DateTime.Now.Year - this.DataDiNascita.Year;
                if (this.DataDiNascita.DayOfYear - DateTime.Now.DayOfYear >= 0)
                    numeroAnni--;
                return numeroAnni;
            }
        }

        

    }

public enum ColoreOcchi
    {
        NonDichiarato,
        Blu,
        Verdi,
        Azzurri,
        Marroni,
        Neri
    }



}
