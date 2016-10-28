using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasiOOP
{
    class Studente : Persona
    {
        public Studente(string cognome, string scuola) : base(cognome)
        {
            this.Scuola = scuola;
        }

        public int Matricola { get; set; }
        public string Scuola { get; set; }

        public void Metodo1()
        {

            this.MProtected();
        }
    }
}
