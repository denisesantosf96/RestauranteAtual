using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAtual.Domain
{
    public class Pedido
    {
        public int Id { get; set; }

        public int IdMesa { get; set; }

        public int IdCliente { get; set; }

        public DateTime Data { get; set; }

        public string Status { get; set; }

        public int QuantidadeDeItens { get; set; }

        public string FormaPagamento { get; set; }
        public decimal Valor { get; set; }

        public Mesa Mesa { get; set; }
        public Cliente Cliente { get; set; }

        public ItensPedido ItensPedido { get; set; }
    }
}
