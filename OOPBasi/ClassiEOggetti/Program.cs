using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiEOggetti
{
    class Programma
    {
        static void Main(string[] args)
        {
      
            IAnimale Mezzo;
    
            Mezzo = new Cavallo();

       
            Mezzo.Mangiafre(23);

        }
    }

    abstract class MezzoDitrasporto
    {
        abstract public int Accelera();

        public int M1()
        {
            return 1;
        }
    }

    class Cavallo : MezzoDitrasporto, IAnimale
    {
        private int aPrivate = 2;
        protected int aProtected = 3;
        public int aPublic = 4;

        public override int Accelera()
        {
            return 4;
        }
        public int Mangia()
        {
            // Qui vedo tutto.
            this.aPrivate = 12;
            return 12;
        }

        public void Mangiafre(int kgCibo)
        {
            throw new NotImplementedException();
        }

        public void Dormire(int oreDiSonno)
        {
            throw new NotImplementedException();
        }
    }
    class Automobile : MezzoDitrasporto
    {    

        public IEnumerable<int> aaa()
        {
            int[] lista = new int[] { 1, 3, 6, 1 };
            return lista;
        }

        public override int Accelera()
        {
            return 56;
        }
    }

    public interface IAnimale
    {
        void Mangiafre(int kgCibo);
        void Dormire(int oreDiSonno);
    }


}
