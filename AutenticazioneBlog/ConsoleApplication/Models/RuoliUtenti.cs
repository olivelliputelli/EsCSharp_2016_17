using System;
using System.Collections.Generic;

namespace ConsoleApplication.Models
{
    public partial class RuoliUtenti
    {
        public int RuoloId { get; set; }
        public string UtenteId { get; set; }
        public DateTime? DataInserimento { get; set; }

        public virtual Ruoli Ruolo { get; set; }
        public virtual Utenti Utente { get; set; }
    }
}
