using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static byte[] buffer { get; set; }
        static byte[] bytesMessaggio { get; set; }
        static Socket sck;
        static void Main()
        {
            Console.WriteLine("**************  SERVER  ***************");
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(0, 1234));
            sck.Listen(10);

            Console.Write("server in ascolto..");
            Socket accepted = sck.Accept();
            Console.WriteLine("CONNESSO!!");
            buffer = new byte[accepted.SendBufferSize];
            
            string strData;
  
            do
            {
                int bytesRicevuti = accepted.Receive(buffer);
                bytesMessaggio = new byte[bytesRicevuti];
                for (int i = 0; i < bytesRicevuti; i++)
                {
                    bytesMessaggio[i] = buffer[i]; 
                }


                strData = Encoding.ASCII.GetString(bytesMessaggio);
                Console.WriteLine(strData);
            } while (strData.ToUpper() != "F");

            sck.Close();
            accepted.Close();
        }
    }
}
