using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sck;
            byte[] messaggioByte = new byte[1024];
            byte[] messaggioByteRicevuti = new byte[1024];
            string charRicevuti = "";
            string messaggio = "", messaggioRicevuto = "";
            int numeroBytesRicevuti = 0;
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sck.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345));
            do
            {
                Console.Write("Messaggio: ");
                messaggio = Console.ReadLine();

                messaggioByte = Encoding.ASCII.GetBytes(messaggio);
                sck.Send(messaggioByte);

                // Ascolto risposta
                messaggioRicevuto = "";
                numeroBytesRicevuti = sck.Receive(messaggioByteRicevuti);

                charRicevuti = Encoding.ASCII.GetString(messaggioByteRicevuti);

                for (int i = 0; i < numeroBytesRicevuti; i++)
                {
                    messaggioRicevuto += charRicevuti[i];
                }
                Console.WriteLine(messaggioRicevuto);

            } while (messaggio.ToUpper() != "F");

            sck.Close();
            Console.ReadKey();
        }
    }
}
