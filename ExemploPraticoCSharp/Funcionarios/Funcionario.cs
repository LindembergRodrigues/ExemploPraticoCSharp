

using ExemploPraticoCSharp.Pessoas;

namespace ExemploPraticoCSharp.Funcionarios
{
    public class Funcionario : Pessoa
    {
        public String  Setor { get; set; }
        public double Salario { get; }
        public String id { get; }
        public Funcionario(String id, string nome, string CPF, Endereco enderecos, string setor, double salario) : base(nome, CPF, enderecos)
        {
            this.id = id;
            Setor = setor;
            Salario = salario;
        }
    }
}
