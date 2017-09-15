using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MeusPedidos_Brunno.Models
{
    public partial class Context : DbContext
    {
        public virtual DbSet<Candidato> Candidato { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=C:\Users\BiGeR777\Desktop\Testes_Develing\MeusPedidos_Brunno\MeusPedidosDB.mdf;Trusted_Connection=True;");
            }
        }*/

        public Context(DbContextOptions<Context> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidato>(entity =>
            {
                entity.Property(e => e.Css).HasColumnName("CSS");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Html).HasColumnName("HTML");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
