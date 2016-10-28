using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasiOOP
{

    public class Persona
    {


            public int PersonaId { get; set; }
        public string Cognome { get; set; }


        public Persona(string cognome)
        {
            this.Cognome = cognome;
        }


        private int MP1()
        {
            return 12;
        }

        protected int MProtected()
        {
            return 128;
        }

        public int Eta()
        {
            return this.MP1();
        }

        public static int MS1()
        {
            return 100;
        }
    }
}
