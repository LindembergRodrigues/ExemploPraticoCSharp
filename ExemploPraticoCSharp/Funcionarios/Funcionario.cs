

using ExemploPraticoCSharp.Pessoas;

namespace ExemploPraticoCSharp.Funcionarios
{
    public abstract class Funcionario : Pessoa
    {
        public String  Setor { get; set; }
        public double Salario { get; private set; }
        private int id;
        protected Funcionario(int id, string nome, string CPF, Endereco enderecos, string setor, double salario) : base(nome, CPF, enderecos)
        {
            this.id = id;
            Setor = setor;
            Salario = salario;
        }
    }
}
