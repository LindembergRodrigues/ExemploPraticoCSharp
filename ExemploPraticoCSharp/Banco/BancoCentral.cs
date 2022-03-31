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
        public int QtdClientes { get; private set; }
        private int qtdFuncionarios;

        public Conta[] Contas { get;  }
        private Funcionario[] funcionarios;

        public BancoCentral(String nome, String agencia, Endereco endereco)
        {
            this.nome = nome;
            this.agencia = agencia;
            this.endereco = endereco;
            QtdClientes = 0;
            this.qtdFuncionarios = 0;
            Contas = new Conta[50];
            funcionarios = new Funcionario[50];
        }

        public void AbrirConta(Conta conta)
        {
            Contas[QtdClientes] = conta;
            QtdClientes++;

        }

        public void FecharConta(String idConta)
        {
            for (int i = 0; i < QtdClientes; i++)
            {
                if (Contas[i].IdConta == idConta)
                {
                    Contas[i] = null;
                    QtdClientes++;
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
            for (int i = 0; i < QtdClientes; i++)
            {
                if (funcionarios[i].id == idFuncionario)
                {
                    Contas[i] = null;
                    QtdClientes++;
                }
                // chama reordena
            }

        }

    }

}
