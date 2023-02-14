using Microsoft.EntityFrameworkCore;
using RestauranteAtual.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAtual.Infrastructure.Data
{
    public class RestauranteDbContext : DbContext
    {
        public RestauranteDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Garcom> Garcons { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItensPedido> ItensPedidos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RestauranteDbContext).Assembly);
        }
    }
}
