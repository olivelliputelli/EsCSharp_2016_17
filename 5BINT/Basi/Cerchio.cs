using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basi
{
    public class Cerchio
    {
        private double raggio;

        public double Raggio
        {
            get { return raggio; }
            set
            {
                if (value >= 0 && value < 1000)
                    raggio = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public Cerchio(double raggio)
        {
            this.Raggio = raggio;
        }
        public Cerchio()
        {}

        public double Area()
        {
            return Math.PI * Math.Pow(this.Raggio,2);
        }
        public double Circonferenza()
        {
            return 2* Math.PI * this.Raggio;
        }


    }
}
