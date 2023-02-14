using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAtual.Domain
{
    public class ItensPedido
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdGarcom { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorItem { get; set; }
        public Pedido Pedido { get; set; }
        public Garcom Garcom { get; set; }
        public Produto Produto { get; set; }
    }
}
