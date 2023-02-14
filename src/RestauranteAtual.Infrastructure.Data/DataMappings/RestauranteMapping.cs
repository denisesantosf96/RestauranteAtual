using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteAtual.Domain;

namespace RestauranteAtual.Infrastructure.Data.DataMappings
{
    public class RestauranteMapping: IEntityTypeConfiguration<Restaurante>
    {
        public void Configure(EntityTypeBuilder<Restaurante> builder)
        {
            builder.ToTable("RESTAURANTE");
            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .UseIdentityColumn();

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.CNPJ)
                .HasColumnName("CNPJ")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.Telefone)
                .HasColumnName("TELEFONE")
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

            builder.Property(p => p.HorarioFuncionamento)
                .HasColumnName("HORARIOFUNCIONAMENTO")
                .HasColumnType("varchar")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(p => p.QuantidadeMaxima)
                .HasColumnName("QUANTIDADEMAXIMA")
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(p => p.QuantidadeMesa)
                .HasColumnName("QUANTIDADEMESA")
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
