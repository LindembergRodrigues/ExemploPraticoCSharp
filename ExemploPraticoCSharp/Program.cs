using ExemploPraticoCSharp.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploPraticoCSharp.Banco;
using ExemploPraticoCSharp.Clientes;
using ExemploPraticoCSharp.Funcionarios;

namespace ExemploPraticoCSharp
{
    class Program
    {
        private const string V = "ok";
        private static BancoCentral banco;
        public static void Main(String[] args)
        {
            IdentificaUser();
        }

        private static BancoCentral CriaBanco()
        {
            Console.WriteLine("CADASTRAR AGÊNCIA BANCARIA");
            Console.Write("Nome do Banco: ");
            string nome = Console.ReadLine();
            Console.Write("Rua: ");
            String rua = Console.ReadLine();
            Console.Write("Numero: ");
            int numero = Console.Read();
            Console.Write("Bairro: ");
            String bairro = Console.ReadLine();
            Console.Write("Cidade: ");
            String cidade = Console.ReadLine();

            Console.Write("Nº da Agência: ");
            int agencia = Console.Read();
            Console.ReadLine();
            Endereco endereco = new Endereco(rua, bairro, numero, cidade);

            return new BancoCentral(nome, endereco, agencia);
        }
        private static Cliente CriaCliente(int agencia)
        {
            Console.WriteLine("CADASTRAR CLIENTE ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");

            string CPF = Console.ReadLine();
            Console.Write("Rua: ");
            String rua = Console.ReadLine();
            Console.Write("Bairro: ");
            String bairro = Console.ReadLine();
            Console.Write("Numero: ");
            int numero = Console.Read();
            Console.Write("Cidade: ");
            String cidade = Console.ReadLine();

            Endereco endereco = new Endereco(rua, bairro, numero, cidade);

            Console.Write("Conta: ");
            int idConta = Console.Read();
            Console.Write("Deposito: ");
            double deposito = Console.Read();
            Console.Write("1 - Conta Corrente\t2 - Conta Poupança");
            int tipoConta = Console.Read();

            Conta conta = new Conta(agencia.ToString(), idConta, deposito, tipoConta);

            return new Cliente(nome, CPF, endereco, conta);
        }
        public static void IdentificaUser()
        {
            while (true)
            {
                Console.WriteLine("(C)liente: \n(F)uncionário: \nCa(D)astrar Funcionario: \n(S)air\n>>");
                String opcao = Console.ReadLine();
                if (opcao.ToUpper() == "C")
                {
                    MenuCliente();
                }
                else if (opcao.ToUpper() == "F")
                {
                    MenuFuncionario();
                }
                else if (opcao.ToUpper() == "D")
                {
                    //CadastraFuncionario();
                }
                else if (opcao.ToUpper() == "S")
                {
                    break;
                }
                Console.WriteLine("Opção invalida!");
            }
        }

        /* private static Funcionario CadastraFuncionario()
         {
             Console.Write("Nome:");
             String nome = Console.ReadLine();
             Console.Write("CPF:");
             String cpf = Console.ReadLine();
             Console.Write("Rua:");
             String rua = Console.ReadLine();
             Console.Write("Numero:");
             String bairro = Console.ReadLine();
             int numero = Console.Read();
             Console.Write("Cidade:");
             String cidade = Console.ReadLine();
             Endereco endereco = new Endereco(rua, bairro, numero, cidade);
             Console.Write("Departamento:");
             String departamento = Console.ReadLine();
             Console.Write("Salario:");
             double salario = Console.Read();

             return new Funcionario(nome,cpf, endereco,departamento, salario);
         }
 */
        private static void MenuFuncionario()
        {

            Console.WriteLine("(C)adastrar Funcionario: \n" +
                "(A)cessar dados:");
            String opcao = Console.ReadLine();
            if (opcao.ToUpper() == "C")
            {

            }


        }

        private static void MenuCliente()
        {
            Console.WriteLine("Informe seu CPF");
            String CPF = Console.ReadLine();
            if (banco.isCliente(CPF))
            {
                Console.WriteLine("Encontrado!");
            }
            else
            {
                Console.WriteLine("Usuario não identificado!");
                MenuFuncionario();
            }
        }


    }
}
