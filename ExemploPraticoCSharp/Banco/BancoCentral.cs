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

        private Cliente[] clientes;
        private Funcionario[] funcionarios;

        public BancoCentral (String agencia, Endereco endereco)
        {
            this.agencia = agencia;
            this.endereco = endereco;
            this.qtdClientes = 0;
            this.qtdFuncionarios = 0;
            clientes = new Cliente[50];
            funcionarios = new Funcionario[50];
        }

        public void AbrirConta()
        {
            clientes[qtdClientes] = conta
            
        }
    }
        
}
