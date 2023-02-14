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
    public class ItensPedidoMapping : IEntityTypeConfiguration<ItensPedido>
    {
        public void Configure(EntityTypeBuilder<ItensPedido> builder)
        {
            builder.ToTable("ITENSPEDIDO");
            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .UseIdentityColumn();

            builder.HasOne(n => n.Pedido)
                .WithOne(n => n.ItensPedido)
                .HasForeignKey<ItensPedido>(k => k.IdPedido);

            builder.HasOne(n => n.Garcom)
                .WithOne(n => n.ItensPedido)
                .HasForeignKey<ItensPedido>(k => k.IdGarcom);

            builder.HasOne(n => n.Produto)
                .WithOne(n => n.ItensPedido)
                .HasForeignKey<ItensPedido>(k => k.IdProduto);

            builder.Property(p => p.Quantidade)
                .HasColumnName("QUANTIDADE")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.ValorItem)
                .HasColumnName("VALORITEM")
                .HasColumnType("decimal")
                .HasPrecision(7, 2)
                .IsRequired();

        }
    }
}
