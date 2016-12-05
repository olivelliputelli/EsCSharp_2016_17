using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static byte[] buffer { get; set; }
        static Socket sck;

        static void Main()
        {
            Console.WriteLine("**************  CLIENT  ***************");
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            try
            {
                sck.Connect(localEndPoint);
            }
            catch (Exception)
            {
                Console.WriteLine("Connessione fallita...");
                Main();
            }
            string messaggio;
            do
            {
                Console.Write("Messaggio: ");
                messaggio = Console.ReadLine();

                byte[] data = Encoding.ASCII.GetBytes(messaggio);

                sck.Send(data);
                Console.WriteLine("Messaggio spedito!");
            } while (messaggio.ToUpper() != "F");
            sck.Close();
        }
    }
}
