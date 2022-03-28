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
        private String Banco { get; set; }
        private Endereco endereco;
        public int Agencia { get; set; }
        private Cliente[] cliente;
        private Funcionario[] funcionarios;
        public int qtdClientes { get; private set; }
        public int qtdColaboradores { get; private set; }

        public BancoCentral(String banco, Endereco endereco, int agencia)
        {
            Banco = banco;
            this.endereco = endereco;
            this.Agencia = agencia;
            cliente = new Cliente[50];
            funcionarios = new Funcionario[50];
            qtdClientes = 0;
            qtdColaboradores = 0;
        }

        public bool isCliente(String cpf)
        {
            bool isCliente = false;
            for (int i = 0; i < qtdClientes; i++)
            {
                if (cliente[i].Equals(cpf))
                {
                    isCliente = true;
                    break;
                }
            }
            return isCliente;
        }

        public bool isFuncionario(String cpf)
        {
            bool isFuncionario = false;
            for (int i = 0; i < qtdClientes; i++)
            {
                if (cliente[i].Equals(cpf))
                {
                    isFuncionario  = true;
                    break;
                }
            }
            return isFuncionario;
        }

       
    }
        
}
