
namespace ExemploPraticoCSharp.Pessoas
{
    public class Pessoa
    {
        protected String Nome { get; set; }
        protected String CPF { get; set; }
        protected Endereco Enderecos { get; set; }

        public Pessoa(string nome,String CPF, Endereco enderecos)
        {
            Nome = nome;
            this.CPF = CPF;
            Enderecos = enderecos;
        }

     }
}

