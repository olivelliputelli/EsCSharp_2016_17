using System;
using System.Collections.Generic;

namespace ConsoleApplication.Models
{
    public partial class Utenti
    {
        public Utenti()
        {
            Blogs = new HashSet<Blogs>();
            RuoliUtenti = new HashSet<RuoliUtenti>();
        }

        public string UserName { get; set; }
        public string Nominativo { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string NumeroDiTelefono { get; set; }
        public bool ConfermaNumeroDiTelefono { get; set; }
        public DateTime? DataInserimento { get; set; }

        public virtual ICollection<Blogs> Blogs { get; set; }
        public virtual ICollection<RuoliUtenti> RuoliUtenti { get; set; }
    }
}
