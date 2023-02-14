using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAtual.Domain
{
    public class Mesa
    {
        public int Id { get; set; }
        public int IdRestaurante { get; set; }
        public string Localizacao { get; set; }
        public int NumeroDaMesa { get; set; }

        public Restaurante Restaurante { get; set; }
        public Pedido Pedido { get; set; }
    }
}
