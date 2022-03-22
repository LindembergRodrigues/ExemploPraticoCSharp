
namespace ExemploPraticoCSharp.Pessoas
{
    public class Pessoa
    {
        public String Nome { get; set; }
        public String CPF { get; set; }
        public Endereco Enderecos { get; set; }

        public Pessoa(string nome,String CPF, Endereco enderecos)
        {
            Nome = nome;
            this.CPF = CPF;
            Enderecos = enderecos;
        }

     }
}

