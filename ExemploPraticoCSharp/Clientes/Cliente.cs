using ExemploPraticoCSharp.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPraticoCSharp.Clientes
{
    class Cliente : Pessoa
    {
        public String  Conta { get; set; }
        public String Agencia { get; set; }
        public double Saldo { get; set; }
        public Cliente(string nome, string CPF, Endereco enderecos, String agencia, String conta) : base(nome, CPF, enderecos)
        {
            Conta = conta;
            Agencia = agencia;
            Saldo = 0;
        }

        public string Name { get; set; }
    }
}
