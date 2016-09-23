using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
