using Barbearia.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Barbearia.Infra.Data.Context
{
    public class BarbeariaContext : DbContext
    {
        public DbSet<Barbeiro> Barbeiros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public BarbeariaContext(DbContextOptions<BarbeariaContext> options)
    : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BancoBarbearia;Trusted_Connection=True;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    }
}