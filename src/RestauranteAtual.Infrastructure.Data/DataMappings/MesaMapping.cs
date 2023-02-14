using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteAtual.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAtual.Infrastructure.Data.DataMappings
{
    public class MesaMapping : IEntityTypeConfiguration<Mesa>
    {
        public void Configure(EntityTypeBuilder<Mesa> builder)
        {
            builder.ToTable("MESA");
            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .UseIdentityColumn();

            builder.Property(p => p.Localizacao)
                .HasColumnName("LOCALIZACAO")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.NumeroDaMesa)
                .HasColumnName("NUMERODAMESA")
                .HasColumnType("int")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasOne(n => n.Restaurante)
                .WithOne(n => n.Mesa)
                .HasForeignKey<Mesa>(k => k.IdRestaurante);

           

        }

    }
}
