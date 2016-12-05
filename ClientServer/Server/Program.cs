using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = new byte[1024];
            Socket sck, sckConnessione;
            int numeroBytesRicevuti = 0;
            string messaggioRicevuto = "", charRicevuti = "";

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(0, 12345));
            sck.Listen(10);

            Console.Write("Sto connettendomi...");
            //Accept() crea una NUOVA SOCKET per gestire la comunicazione.
            sckConnessione = sck.Accept();
            Console.Write("CONNESSO!!");

            do
            {
                messaggioRicevuto = "";             
                numeroBytesRicevuti = sckConnessione.Receive(buffer);

                charRicevuti = Encoding.ASCII.GetString(buffer);

                for (int i = 0; i < numeroBytesRicevuti; i++)
                {
                    messaggioRicevuto += charRicevuti[i];
                }                
                Console.WriteLine(messaggioRicevuto);
                switch (messaggioRicevuto.ToUpper())
                {
                    case "NU":
                        sckConnessione.Send(Encoding.ASCII.GetBytes("Nuovo Utente***"));
                        break;
                    case "LU":
                        sckConnessione.Send(Encoding.ASCII.GetBytes("Lista Utenti***"));
                        break;
                    default:
                        sckConnessione.Send(Encoding.ASCII.GetBytes("***"));
                        break;
                }


            } while (messaggioRicevuto.ToUpper() != "F");


            sck.Close();
            sckConnessione.Close();

            Console.ReadLine();
        }
    }
}
