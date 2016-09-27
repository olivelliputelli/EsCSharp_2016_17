using System.ComponentModel.DataAnnotations;

namespace Es1_ClassePersona
{
    public class Persona
    {
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "Il {0} lo devi mettere!")]
        [StringLength(20, ErrorMessage ="{0} massimo {1} caratteri!")]
        public string Cognome { get; set; }
        [MinLength(3, ErrorMessage = "Minima lunghezza del {0} e' {1}!")]
        public string Nome { get; set; }

        [Range(1900, 2050, ErrorMessage = "L'anno della data di nascita deve essere tra {1} e {2}!")]
        public int AnnoDiNascita { get; set; }

        [RegularExpression(@"[1-5][A-F]", ErrorMessage ="La sigla {0} non e' valida!")]
        public string ClasseFrequentata { get; set; }
        public ColoreOcchi Occhi { get; set; }
    

        public override string ToString()
        {
            return $"{this.Cognome} {this.Nome} del {this.AnnoDiNascita} frequenta la {this.ClasseFrequentata} ";
        }
    }

    public enum ColoreOcchi
    {
        Blu,
        Marroni,
        Neri,
        Verdi,
        NonSpecificato
    }
}
