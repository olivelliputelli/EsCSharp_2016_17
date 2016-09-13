using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es3_StruttureDiControllo
{
    class Cerchio
    {
        private double raggio = 0.0D;

        public double Raggio
        {
            get { return raggio; }
            set
            {
                if (value >= 0) raggio = value;
                else throw new IndexOutOfRangeException;
            }
        }

        public double Altezza { get; set; }

    }
}
