﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAtual.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public decimal Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }
        public string Genero { get; set; }
        public DateTime? DataNascimento { get; set; }

        public Pedido Pedido { get; set; }
    }
}
