using System;
using System.IO;
using System.Net;

namespace PaginaWeb
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Inizio..");
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://isolivelli.it/");

            File.WriteAllText(@"C:\Users\olive\Desktop\WriteText.txt", reply);

            Console.WriteLine("Fine!");
        }
    }
}
