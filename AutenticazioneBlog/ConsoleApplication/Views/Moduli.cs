using ConsoleApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ConsoleApplication.Views
{
    public class Moduli
    {
        public static void ModuloNuovoUtente()
        {
            Clear();
            WriteLine("**** M O D U L O      R E G I S T R A Z I O N E      U T E N T E *************");
            Write("Nominativo: ");
            var nominativo = ReadLine();
            Write("User Name: ");
            var user = ReadLine();
            Write("Psw: ");
            var psw = ReadLine();
            Utenti utente = new Utenti() { Nominativo = nominativo, UserName = user, PasswordHash = (new Cripta(psw)).DaPasswordAPasswordHash(), NumeroDiTelefono = "123456", Email = "ddgg@dd.iy" };

            using (var context = new AutenticazioneBlogDBContext())
            {
                context.Utenti.Add(utente);
                context.SaveChanges();
            }
            WriteLine("Utente inserito!");
            ReadKey();
        }

        public static void ModuloAssegnazioneRuoloUtente()
        {
            Clear();
            WriteLine("****  RUOLO <-> UTENTE  *************");
            WriteLine("LISTA UTENTI:");
            using (var context = new AutenticazioneBlogDBContext())
            {
                context.Utenti.ToList().ForEach(u => WriteLine($"{u.UserName} - {u.Nominativo}"));
                Write("Inserire username:");
                var username = ReadLine();
                context.Ruoli.ToList().ForEach(r => WriteLine($"{r.RuoloId} - {r.Nome}"));
                Write("Inserire id ruolo:");
                int ruolo = int.Parse(ReadLine());
                context.RuoliUtenti.Add(new RuoliUtenti() { UtenteId = username, RuoloId = ruolo });
                context.SaveChanges();
            }
        }
    }
}
