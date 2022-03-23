using ExemploPraticoCSharp.Banco;
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
        public Conta  Conta { get; set; }
  
        public Cliente(string nome, string CPF, Endereco enderecos, Conta conta) : base(nome, CPF, enderecos)
        {
            Conta = conta;
            
        }

        
    }
}
 