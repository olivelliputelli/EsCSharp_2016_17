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
            string messaggio = "";
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sck.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345));
            do
            {
                Console.Write("Messaggio: ");
                messaggio = Console.ReadLine();

                messaggioByte = Encoding.ASCII.GetBytes(messaggio);
                sck.Send(messaggioByte);

            } while (messaggio.ToUpper() != "F");

            sck.Close();
            Console.ReadKey();
        }
    }
}
