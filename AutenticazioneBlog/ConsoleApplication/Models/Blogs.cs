using System;
using System.Collections.Generic;

namespace ConsoleApplication.Models
{
    public partial class Blogs
    {
        public int BlogId { get; set; }
        public string UtenteId { get; set; }
        public string IndirizzoUrl { get; set; }
        public DateTime? DataInserimento { get; set; }

        public virtual Utenti Utente { get; set; }
    }
}
