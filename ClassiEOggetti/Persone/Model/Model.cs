
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Persone.Model
{
    public class PersoneContext : DbContext
    {
        public DbSet<Persona> Persone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Persone5BINTDB;Trusted_Connection=True;");
        }
    }
}