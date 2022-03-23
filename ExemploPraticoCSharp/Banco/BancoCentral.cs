using ExemploPraticoCSharp.Pessoas;
using ExemploPraticoCSharp.Clientes;
using ExemploPraticoCSharp.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPraticoCSharp.Banco
{
    internal class BancoCentral
    {
        private String banco { get; set; }
        private Endereco endereco;
        private Cliente[] cliente;
        private Funcionario[] funcionarios;
        private int agencia;
        public static int qtdClientes { get; protected set; }
        public static int qtdColaboradores { get; protected set; }

        public BancoCentral(Endereco endereco, int agencia)
        {
            this.endereco = endereco;
        }
        
}
