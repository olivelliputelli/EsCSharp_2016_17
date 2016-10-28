using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegareDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                Console.Write("Blog: ");                         
                db.Blogs.Add(new Blog { Url = Console.ReadLine() });
                var count = db.SaveChanges();
                Console.WriteLine($"{count} records saved to database");

                Console.WriteLine("**************");
                db.Blogs.ToList().ForEach(b => Console.WriteLine(b));
            }

        }
    }
}
