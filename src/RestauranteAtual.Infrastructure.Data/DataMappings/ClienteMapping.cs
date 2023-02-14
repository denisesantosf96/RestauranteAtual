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
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("CLIENTE");
            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .UseIdentityColumn();

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.CPF)
                .HasColumnName("CPF")
                .HasColumnType("varchar")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(p => p.RG)
                .HasColumnName("RG")
                .HasColumnType("varchar")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(p => p.Endereco)
                .HasColumnName("ENDERECO")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Numero)
                .HasColumnName("NUMERO")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Bairro)
                .HasColumnName("BAIRRO")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Cidade)
                .HasColumnName("CIDADE")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Estado)
                .HasColumnName("ESTADO")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.Pais)
                .HasColumnName("PAIS")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.CEP)
                .HasColumnName("CEP")
                .HasColumnType("varchar")
                .HasMaxLength(9)
                .IsRequired();

            builder.Property(p => p.Genero)
                .HasColumnName("GENERO")
                .HasColumnType("char")
                .IsRequired();

            builder.Property(p => p.DataNascimento)
                .HasColumnName("DATANASCIMENTO")
                .HasColumnType("datetime")
                .IsRequired();

        }
    }
}
