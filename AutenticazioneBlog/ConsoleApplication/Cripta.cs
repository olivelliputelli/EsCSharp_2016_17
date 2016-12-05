using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Cripta
    {
        private string _psw ="";
        private const int _seme = 3;
        
        public Cripta(string password)
        {
            _psw = password;
        }

        public string DaPasswordAPasswordHash()
        {
            string psw ="";
            for (int i = 0; i < _psw.Length; i++)
            {
                psw += (char)((int)_psw[i]+ _seme);
            }   
            return psw;
        }

        public string DaPasswordHashAPassword()
        {
            string psw = "";
            for (int i = 0; i < _psw.Length; i++)
            {
                psw += (char)((int)_psw[i] - _seme );
            }
            return psw;
        }



    }
}
