using ExemploPraticoCSharp.Banco;
using ExemploPraticoCSharp.Funcionarios;
using ExemploPraticoCSharp.Pessoas;

namespace ExemploPraticoCSharp
{
    class Program
    {
        public static void Main(String [] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("<Primeiro Acesso>\nCadastrando Banco ... ");
            BancoCentral BC = InicialiaBanco(); //CadastraBanco();
            Console.WriteLine("\n<Cadastrando colaborador ...");
            Funcionario F = InicialiaColaborador();
            BC.ContrataFuncionario(F);
            
        }
        public static BancoCentral CadastraBanco()
        {
            Console.WriteLine("NOME DO BANCO: ");
            string nome =  Console.ReadLine();
            Console.WriteLine("ID AGÊNCIA: ");
            String idAgencia = Console.ReadLine();
            Console.WriteLine("RUA: ");
            String rua = Console.ReadLine();
            Console.WriteLine("BAIRRO: ");
            String Bairro = Console.ReadLine();
            Console.WriteLine("CIDADE: ");
            String cidade = Console.ReadLine();
            Console.WriteLine("NUMERO: ");
            int numero = Console.Read();
            Endereco endereco = new Endereco(rua, Bairro, numero, cidade);


            return new BancoCentral(nome,idAgencia,endereco);
        }

        private static BancoCentral InicialiaBanco() 
        {
            Endereco endereco = new Endereco("Rua das Flores", "Centro", 152, "Mênfis");
            
            return new BancoCentral("MAD", "0211", endereco);
        }

        private static Funcionario InicialiaColaborador()
        {
            Endereco endereco = new Endereco("Av. Nova América", "Distrito dos Ferros", 365, "Mênfis");

            return new Funcionario("8546", "Lindemberg", "123.456.789-09", endereco, "TI", 2750.0);
        }
    }
}
