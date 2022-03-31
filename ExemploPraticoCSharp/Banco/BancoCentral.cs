using ExemploPraticoCSharp.Clientes;
using ExemploPraticoCSharp.Funcionarios;
using ExemploPraticoCSharp.Pessoas;

namespace ExemploPraticoCSharp.Banco
{
    internal class BancoCentral
    {
        private String nome;
        private String agencia;
        private Endereco endereco;
        public int QtdClientes { get; }
        private int qtdFuncionarios;

        public Conta[] Contas { get;  }
        private Funcionario[] funcionarios;

        public BancoCentral(String nome, String agencia, Endereco endereco)
        {
            this.nome = nome;
            this.agencia = agencia;
            this.endereco = endereco;
            this.qtdClientes = 0;
            this.qtdFuncionarios = 0;
            contas = new Conta[50];
            funcionarios = new Funcionario[50];
        }

        public void AbrirConta(Conta conta)
        {
            contas[qtdClientes] = conta;
            qtdClientes++;

        }

        public void FecharConta(String idConta)
        {
            for (int i = 0; i < qtdClientes; i++)
            {
                if (contas[i].IdConta == idConta)
                {
                    contas[i] = null;
                    qtdClientes++;
                }
                // chama reordena
            }

        }

        public void ContrataFuncionario(Funcionario funcionario)
        {
            funcionarios[qtdFuncionarios] = funcionario;
        }

        public void DesligaFuncionario(String idFuncionario)
        {
            for (int i = 0; i < qtdClientes; i++)
            {
                if (funcionarios[i].id == idFuncionario)
                {
                    contas[i] = null;
                    qtdClientes++;
                }
                // chama reordena
            }

        }

    }

}
