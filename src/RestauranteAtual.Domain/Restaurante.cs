using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAtual.Domain
{
    public class Restaurante
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Pais { get; set; }

        public string CEP { get; set; }

        public string HorarioFuncionamento { get; set; }

        public string QuantidadeMaxima { get; set; }

        public int QuantidadeMesa { get; set; }

        public Mesa Mesa { get; set; }

        public ICollection<Mesa> Mesas { get; set; } = default;
    }
}
