using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasiOOP
{
    class Programma
    {
        static void Main()
        {

            MyClassA1 O1 = new MyClassA1();
            
        }
    }

    

    abstract class MyClassA
    {
        public abstract int M1();
        public void M2()
        { 
            // Codice
        }
    }

    class MyClassA1:MyClassA, IInterfaccia1, IInterfaccia2
    {
        public int MyProperty1 { get; set; }
        public int M11() { return 1; };
        public void M12() { };
        public override int M1() { return 1; }
        public int M3() { return 3; }
    }

    class MyClassA2:MyClassA
    {

    }

}
