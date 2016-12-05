using System;
using System.Collections.Generic;

namespace ConsoleApplication.Models
{
    public partial class Ruoli
    {
        public Ruoli()
        {
            RuoliUtenti = new HashSet<RuoliUtenti>();
        }

        public int RuoloId { get; set; }
        public string Nome { get; set; }
        public string NomeNormalizzato { get; set; }

        public virtual ICollection<RuoliUtenti> RuoliUtenti { get; set; }
    }
}
