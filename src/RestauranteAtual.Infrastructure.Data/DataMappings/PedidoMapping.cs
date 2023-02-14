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
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("PEDIDO");
            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .UseIdentityColumn();

            builder.HasOne(n => n.Mesa)
                .WithOne(n => n.Pedido)
                .HasForeignKey<Pedido>(k => k.IdMesa);

            builder.HasOne(n => n.Cliente)
                .WithOne(n => n.Pedido)
                .HasForeignKey<Pedido>(k => k.IdCliente);

            builder.Property(p => p.Data)
                .HasColumnName("DATA")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.Status)
                .HasColumnName("STATUS")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.QuantidadeDeItens)
                .HasColumnName("QUANTIDADEDEITENS")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.FormaPagamento)
                .HasColumnName("FORMAPAGAMENTO")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Valor)
                .HasColumnName("VALOR")
                .HasColumnType("decimal")
                .HasPrecision(7, 2)
                .IsRequired();


        }
    }
}
