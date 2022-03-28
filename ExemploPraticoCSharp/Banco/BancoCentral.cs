using ExemploPraticoCSharp.Clientes;
using ExemploPraticoCSharp.Funcionarios;
using ExemploPraticoCSharp.Pessoas;

namespace ExemploPraticoCSharp.Banco
{
    internal class BancoCentral
    {
        private String agencia;
        private Endereco endereco;
        private int qtdClientes;
        private int qtdFuncionarios;

        private Conta[] contas;
        private Funcionario[] funcionarios;

        public BancoCentral (String agencia, Endereco endereco)
        {
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
        }

        public void FecharConta(String idConta)
        {
            for (int i =0; i <qtdClientes; i++)
            {
                if (contas[i].IdConta == idConta )
                {
                    contas[i] = null;
                }
                // chama reordena
            }
            
        }
    }
        
}
