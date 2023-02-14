using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAtual.Domain
{
    public class Garcom
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataAdmissao { get; set; }
        public ItensPedido ItensPedido { get; set; }
    }
}
