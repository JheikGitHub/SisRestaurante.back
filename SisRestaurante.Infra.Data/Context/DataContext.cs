using Microsoft.EntityFrameworkCore;
using SisRestaurante.Domain.Entities;
using SisRestaurante.Infra.Data.Mappings;

namespace SisRestaurante.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Prato> Pratos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PratoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
