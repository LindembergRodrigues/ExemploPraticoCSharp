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
        private static BancoCentral banco;
        public static void Main(String[] args)
        {
            IdentificaUser();
        }

        private static BancoCentral criaBanco()
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
        private static Cliente criaCliente(int agencia)
        {
            Console.WriteLine("CADASTRAR CLIENTE ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string CPF = Console.ReadLine();
            Console.Write("Rua: ");
            String rua = Console.ReadLine();
            Console.Write("Numero: ");
            int numero = Console.Read();
            Console.Write("Bairro: ");
            String bairro = Console.ReadLine();
            Console.Write("Cidade: ");
            String cidade = Console.ReadLine();

            Console.Write("Conta: ");
            string nome = Console.ReadLine();



            Console.Write("Nº da Agência: ");
            int agencia = Console.Read();
            Console.ReadLine();
            Endereco endereco = new Endereco(rua, bairro, numero, cidade);

            return new Cliente(nome, CPF, endereco, conta);
        }
        public static void IdentificaUser()
        {
            while (true)
            {
                if (banco == null)
                {
                    banco = criaBanco();
                }
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
                else if (opcao.ToUpper() == "D")
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

            Console.WriteLine("Cadastrar Funcionario: \n" +
                "(A)cessar dados:");
                
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
