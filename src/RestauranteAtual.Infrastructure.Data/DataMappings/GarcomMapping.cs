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
    public class GarcomMapping : IEntityTypeConfiguration<Garcom>
    {
        public void Configure(EntityTypeBuilder<Garcom> builder)
        {
            builder.ToTable("GARCOM");
            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .UseIdentityColumn();

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Idade)
                .HasColumnName("IDADE")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.DataAdmissao)
                .HasColumnName("DATAADMISSAO")
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}
