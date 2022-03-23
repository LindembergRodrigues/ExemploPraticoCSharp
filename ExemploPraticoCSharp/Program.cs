using ExemploPraticoCSharp.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploPraticoCSharp.Banco;

namespace ExemploPraticoCSharp
{
    class Program
    {
        private static BancoCentral banco;
        public static void Main (String [] args)
        {
            IdentificaUser();
        }

        private static BancoCentral criaBanco()
        {

            Console.Write("Nome do Banco: ");
            string nome = Console.ReadLine();
            Console.Write("Rua: ");
            String rua = Console.ReadLine();
            Console.Write("Rua: ");
            String numero = Console.ReadLine();
            Console.Write("Rua: ");
            String bairro = Console.ReadLine();
            Console.Write("Rua: ");
            String cidade = Console.ReadLine();

            Console.Write("Nº da Agência: ");
            int agencia = Console.Read();

            Endereco endereco = new Endereco(rua, bairro, numero , cidade);

            return new BancoCentral(nome, endereco, agencia);
        }

        public static void IdentificaUser()
        {   if (banco == null)
            {
                banco = criaBanco();
            }
            Console.WriteLine("(C)liente: \n(F)uncionário: \n(S)air\n>>");
            String opcao = Console.ReadLine();
            if (opcao.ToUpper() == "C")
            {
                MenuCliente();
            }else if (opcao.ToUpper() == "F")
            {
                MenuFuncionario();
            }
            Console.WriteLine("Opção invalida!");
        }

        private static void MenuFuncionario()
        {
            Console.WriteLine("Informe seu CPF");
            String CPF= Console.ReadLine();
            if (isCPFValido(CPF))
            {

            }
            else
            {
                
            }
        }

        private static void MenuCliente()
        {
            throw new NotImplementedException();
        }

        public 
    }
}
