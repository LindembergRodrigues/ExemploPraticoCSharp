using ExemploPraticoCSharp.Funcionarios;
using ExemploPraticoCSharp.Pessoas;

namespace ExemploPraticoCSharp.Banco
{
    internal class BancoCentral
    {
        private String nome;
        public String Agencia { get; }
        private Endereco endereco;
        public int QtdClientes { get; private set; }
        private int qtdFuncionarios;

        public Conta[] Contas { get; }
        private Funcionario[] funcionarios;


        public BancoCentral(String nome, String agencia, Endereco endereco)
        {
            this.nome = nome;
            Agencia = agencia;
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

        public void FecharConta(Conta conta)
        {
            for (int i = 0; i < QtdClientes; i++)
            {
                if (Contas[i].Equals(conta))
                {
                    Contas[i] = null;
                    QtdClientes--;
                    reordena(i);
                    break;
                }

            }

        }

        private void reordena(int posicao)
        {
            if (posicao == QtdClientes)
            {
                Contas[posicao] = null;
            }
            else
            {
                for (int i = posicao; i < QtdClientes-1; i++)
                {
                    Contas[posicao] = Contas[posicao + 1];
                }
                Contas[QtdClientes - 1] = null;
            }
        }

        public void ContrataFuncionario(Funcionario funcionario)
        {
            funcionarios[qtdFuncionarios] = funcionario;
            qtdFuncionarios++;
        }
        public void DesligaFuncionario(String idFuncionario)
        {
            for (int i = 0; i < QtdClientes; i++)
            {
                if (funcionarios[i].id == idFuncionario)
                {
                    Contas[i] = null;
                    QtdClientes--;
                }
                // chama reordena
            }

        }
        public Conta isContaValida(Conta conta)
        {
            foreach (Conta idConta in Contas)
            {
                if (idConta.Equals(conta))
                {
                    return idConta;
                }
            }
            return null;
        }
    }
}