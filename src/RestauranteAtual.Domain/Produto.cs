using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAtual.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
        public ItensPedido ItensPedido { get; set; }
    }
}
