using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegareDatabase
{
    class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public override string ToString()
        {
            return $"{this.BlogId} - {this.Url}";
        }
    }
}
