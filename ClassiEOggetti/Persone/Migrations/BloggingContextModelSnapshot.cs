using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Persone.Model;

namespace Persone.Migrations
{
    [DbContext(typeof(PersoneContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Persone.Model.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnnoDinascita");

                    b.Property<string>("CodiceFiscale");

                    b.Property<string>("Cognome")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<int>("Occhi");

                    b.HasKey("PersonaId");

                    b.ToTable("Persone");
                });
        }
    }
}
