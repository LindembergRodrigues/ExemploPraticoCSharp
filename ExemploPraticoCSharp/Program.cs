using ExemploPraticoCSharp.Banco;
using ExemploPraticoCSharp.Clientes;
using ExemploPraticoCSharp.Funcionarios;
using ExemploPraticoCSharp.Pessoas;

namespace ExemploPraticoCSharp
{
    class Program
    {
        public static void Main(String[] args)
        {
            Menu();
        }

        /// <summary>
        /// Inicializa o menu de opções do Banco 
        /// </summary>
        public static void Menu()
        {
            Console.WriteLine("<Primeiro Acesso>\nCadastrando Banco ... ");
            BancoCentral BC = InicialiaBanco(); //CadastraBanco();
            Console.WriteLine("\n<Cadastrando colaborador ...");
            Funcionario F = InicialiaColaborador();
            BC.ContrataFuncionario(F);

            Console.WriteLine("(F)uncionário ou (C)liente ::");
            String opcao = Console.ReadLine();
            if (opcao.ToUpper() == "F")
            {
                Funcionario(BC);
            }
            else if (opcao.ToUpper() == "C")
            {
                Console.WriteLine("ID Cliente");
                String numeroConta = Console.ReadLine();
                Conta conta = BC.isContaValida(new Conta(BC.Agencia, numeroConta));
                if (conta != null)
                    Cliente(BC, conta);
            }
            else
                Console.WriteLine("OPÇÃO INVALIDA!");

        }
        
        /// <summary>
        /// Menu de opção para manutenção de colaboradores
        /// </summary>
        /// <param name="idConta"></param>
        private static void Cliente(BancoCentral bC, Conta conta)
        {
            Console.WriteLine("(V)erifica Saldo" +
                 "\n(S)aque" +
                 "\n(D)epósito" +
                 "\n(T)ransferir");
            String op = Console.ReadLine();
            switch (op.ToUpper())
            {
                case "V":
                    Console.WriteLine(conta._saldo);
                    break;

                case "S":
                    Console.WriteLine("Valor para saque: ");
                    double valorSaque = Console.Read();
                    conta.Sacar(valorSaque);
                    break;

                case "D":
                    Console.WriteLine("Valor para deposito: ");
                    double deposito = Console.Read();
                    conta.Depositar(deposito);
                    break;

                case "T":
                    Console.WriteLine("Valor a transferir: ");
                    double valor = Console.Read();
                    Console.WriteLine("Agencia: ");
                    string agencia = Console.ReadLine();
                    Console.WriteLine("Conta");
                    string IdConta = Console.ReadLine();

                    Conta ContaTransferir = bC.isContaValida(new Conta(agencia, IdConta));
                    if (ContaTransferir != null)
                        conta.Transferir(valor, ContaTransferir);
                    break;
            }
        }
        /// <summary>
        /// Abre o menu de opções do colaborador
        /// </summary>
        private static void Funcionario(BancoCentral bC)
        {
            Console.WriteLine("(A)brir conta" +
                "\n(E)ncerrar conta" +
                "\n(C)ontratar/Cadastrar novo colaborador" +
                "\n(D)esligar colaborador");
            string op = Console.ReadLine();
            switch (op.ToUpper())
            {
                case "A":
                    AbrirConta(bC);
                    foreach()
                    break;
                case "E":
                    EncerrarConta(bC);
                    break;
                case "C":
                    CadastraColaborador(bC);
                    break;
                case "D":
                    DesligarColaborador(bC);
                    break;
            }
        }

        private static void DesligarColaborador(BancoCentral bC)
        {
            Console.WriteLine("ID: ");
            String id = Console.ReadLine();

            bC.DesligaFuncionario(id);
            
        }

        private static void CadastraColaborador(BancoCentral bC)
        {
            Console.WriteLine("NOME: ");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            String cpf = Console.ReadLine();
            Console.WriteLine("RUA: ");
            String rua = Console.ReadLine();
            Console.WriteLine("BAIRRO: ");
            String Bairro = Console.ReadLine();
            Console.WriteLine("CIDADE: ");
            String cidade = Console.ReadLine();
            Console.WriteLine("NUMERO: ");
            int numero = Console.Read();

            Endereco endereco = new Endereco(rua, Bairro, numero, cidade);

            Console.WriteLine("Departamento: ");
            String departamento = Console.ReadLine();
            Console.WriteLine("Salario: ");
            double salario = Console.Read();

            Random r = new Random();
            string idCadastro = r.Next(1000, 9999) + "";

            Funcionario novoFuncionario = new Funcionario(idCadastro, nome, cpf, endereco, departamento, salario);

            bC.ContrataFuncionario(novoFuncionario);
        }

        private static void EncerrarConta(BancoCentral  bC)
        {
            Console.WriteLine("Informe o numero da Conta::");
            String conta = Console.ReadLine();
            bC.FecharConta(new Conta(bC.Agencia, conta));

        }

        private static void AbrirConta(BancoCentral bC)
        {
            Console.WriteLine("NOME: ");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            String cpf = Console.ReadLine();
            Console.WriteLine("RUA: ");
            String rua = Console.ReadLine();
            Console.WriteLine("BAIRRO: ");
            String Bairro = Console.ReadLine();
            Console.WriteLine("CIDADE: ");
            String cidade = Console.ReadLine();
            Console.WriteLine("NUMERO: ");
            int numero = Console.Read();
            Endereco endereco = new Endereco(rua, Bairro, numero, cidade);

            Random r = new Random();
            string novaConta = r.Next(1000, 999999)+"";

            Cliente novoCliente = new Cliente(nome, cpf, endereco);

            Conta aberturaDeConta = new Conta(bC.Agencia, novaConta, novoCliente);

            bC.AbrirConta(aberturaDeConta);
        }

        /// <summary>
        /// Abre o menu de cadastro do Banco
        /// </summary>
        /// <returns> retorna o Objeto do tipo Banco</returns>
        private static BancoCentral CadastraBanco()
        {
            Console.WriteLine("NOME DO BANCO: ");
            string nome = Console.ReadLine();
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


            return new BancoCentral(nome, idAgencia, endereco);
        }

        /// <summary>
        /// Inicializa um banco logo a inicialização do sistema
        /// </summary>
        /// <returns>  retorna o Objeto do tipo Banco </returns>
        private static BancoCentral InicialiaBanco()
        {
            Endereco endereco = new Endereco("Rua das Flores", "Centro", 152, "Mênfis");

            return new BancoCentral("MAD", "0211", endereco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static Funcionario InicialiaColaborador()
        {
            Endereco endereco = new Endereco("Av. Nova América", "Distrito dos Ferros", 365, "Mênfis");

            return new Funcionario("8546", "Lindemberg", "123.456.789-09", endereco, "Gerente", 2750.0);
        }
    }
}
