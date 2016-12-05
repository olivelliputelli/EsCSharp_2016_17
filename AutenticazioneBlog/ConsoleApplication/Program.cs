using ConsoleApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.Views;
using static System.Console;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*******  A P P    B L O G ********");
            WriteLine("Fine - per uscire");
            string usr = "";
            do
            {
                Write("username: ");
                usr = ReadLine();
                if (usr.ToUpper() != "FINE")
                {
                    Write("psw: ");
                    var psw = ReadLine();
                    var pswHash = new Cripta(psw);
         using (var context = new AutenticazioneBlogDBContext())
                    {
                        var utente = context.Utenti.SingleOrDefault(u => u.UserName == usr && u.PasswordHash == pswHash.DaPasswordAPasswordHash());
                        if (utente != null)
                        {
                            WriteLine($"Ciao {utente.Nominativo}!!");
                            ReadKey();
                            if (context.RuoliUtenti.SingleOrDefault(r => r.UtenteId == utente.UserName && r.RuoloId == 1) != null)
                                Menu.MenuAdmin();
                            else
                                Menu.MenuBlogger();
                            break;
                        }
                        else
                        {
                            WriteLine("Autenticazione fallita!!");
                            ReadKey();
                        }
                    }
                }
            } while (usr.ToUpper() != "FINE");
            Write("Fine!!!");
            ReadKey();
        }
    }
}
