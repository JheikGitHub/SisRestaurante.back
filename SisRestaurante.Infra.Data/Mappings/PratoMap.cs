using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisRestaurante.Domain.Entities;

namespace SisRestaurante.Infra.Data.Mappings
{
    public class PratoMap : IEntityTypeConfiguration<Prato>
    {
        public void Configure(EntityTypeBuilder<Prato> builder)
        {
            builder.ToTable("Prato");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.Preco)
               .HasColumnName("Preco")
               .IsRequired();
        }
    }
}
