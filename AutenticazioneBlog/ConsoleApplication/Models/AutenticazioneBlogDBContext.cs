using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApplication.Models
{
    public partial class AutenticazioneBlogDBContext : DbContext
    {
        public virtual DbSet<Blogs> Blogs { get; set; }
        public virtual DbSet<Ruoli> Ruoli { get; set; }
        public virtual DbSet<RuoliUtenti> RuoliUtenti { get; set; }
        public virtual DbSet<Utenti> Utenti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@" Data Source=pridavPortatile\SQLEXPRESS;Initial Catalog=AutenticazioneBlogDB;Persist Security Info=True;User ID=sa;Password=1234567_77");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.HasKey(e => e.BlogId)
                    .HasName("PK_Blogs");

                entity.Property(e => e.DataInserimento)
                    .HasColumnType("date")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IndirizzoUrl)
                    .IsRequired()
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.UtenteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Utente)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(d => d.UtenteId)
                    .HasConstraintName("FK_RuoliUtentiBlogs");
            });

            modelBuilder.Entity<Ruoli>(entity =>
            {
                entity.HasKey(e => e.RuoloId)
                    .HasName("PK_Ruoli");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NomeNormalizzato)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RuoliUtenti>(entity =>
            {
                entity.HasKey(e => new { e.RuoloId, e.UtenteId })
                    .HasName("PK_RuoliUtenti");

                entity.Property(e => e.UtenteId).HasMaxLength(50);

                entity.Property(e => e.DataInserimento)
                    .HasColumnType("date")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Ruolo)
                    .WithMany(p => p.RuoliUtenti)
                    .HasForeignKey(d => d.RuoloId)
                    .HasConstraintName("FK_RuoliUtentiRuoli");

                entity.HasOne(d => d.Utente)
                    .WithMany(p => p.RuoliUtenti)
                    .HasForeignKey(d => d.UtenteId)
                    .HasConstraintName("FK_RuoliUtentiUtenti");
            });

            modelBuilder.Entity<Utenti>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK_Utenti");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.ConfermaNumeroDiTelefono).HasDefaultValueSql("0");

                entity.Property(e => e.DataInserimento)
                    .HasColumnType("date")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Nominativo)
                    .IsRequired()
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.NumeroDiTelefono).HasMaxLength(50);

                entity.Property(e => e.PasswordHash).HasMaxLength(256);
            });
        }
    }
}