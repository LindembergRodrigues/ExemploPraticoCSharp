using ExemploPraticoCSharp.Banco;
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

            Console.WriteLine("(F)uncionário ou (C)olaborador ::");
            String opcao = Console.ReadLine();
            if (opcao.ToUpper() == "F")
            {
                Funcionario();
            }
            else if (opcao.ToUpper() == "C")
            {
                Console.WriteLine("ID colaborador");
                String colaborador = Console.ReadLine();
                int posicao = isColaborador(BC, colaborador);
                if (posicao != -1)
                    Colaborador(BC.Contas[posicao]);
            }
            else
                Console.WriteLine("OPÇÃO INVALIDA!");



        }


        /// <summary>
        /// verifica se o id informado corresponde ao de um colaborador
        /// </summary>
        /// <param name="bC">identificador de banco</param>
        /// <param name="colaborador"> identificador do colaborador</param>
        /// <returns> a situação do colaborador no banco</returns>
        private static int isColaborador(BancoCentral bC, string colaborador)
        {
            for (int i = 0; i < bC.QtdClientes; i++)
            {
                if (bC.Contas[i].IdConta == colaborador)
                {
                    return i;
                    break;
                }
            }
            return -1;
        }

        /// <summary>
        /// Menu de opção para manutenção de colaboradores
        /// </summary>
        /// <param name="idConta"></param>
        private static void Colaborador(Conta conta)
        {
            Console.WriteLine("(V)erifica Saldo" +
                 "\n(S)aque" +
                 "\n(D)epósito" +
                 "\n(T)ransferir");
            String op = Console.ReadLine();
            switch (op.ToUpper())
            {
                case "V":
                    Saldo(conta);
                    break;
                case "S":
                    Console.WriteLine("Valor para saque: ");
                    double valorSaque = Console.Read();
                    sacar(conta, valorSaque);
                    break;
                case "D":
                    Console.WriteLine("Valor para deposito: ");
                    double deposito = Console.Read();
                    depositar(conta, deposito);
                    break;
                case "T":
                    Console.WriteLine("Valor a transferir: ");
                    double valor = Console.Read();
                    Console.WriteLine("Agencia: ");
                    string agencia = Console.ReadLine();
                    Console.WriteLine("Conta");
                    double contaT = Console.Read();
                    transferir(conta, valor, agencia, contaT);
                    break;
            }
        }

        private static void transferir(Conta conta, double valor, string agencia, double contaT)
        {
            
        }

        private static void depositar(Conta conta, double deposito)
        {
            conta.Depositar(deposito);
            Console.WriteLine("Depósitado");
        }

        private static void sacar(Conta conta, double valorSaque)
        {
            conta.Sacar(valorSaque);
            Console.WriteLine("Saque realizado");

        }

        private static void Saldo(Conta conta)
        {
            Console.WriteLine(conta._saldo);
        }

        
        /// <summary>
        /// Abre o menu de opções do colaborador
        /// </summary>
        private static void Funcionario()
        {
            Console.WriteLine("(A)brir conta" +
                "\n(E)ncerrar conta" +
                "\n(C)ontratar/Cadastrar novo colaborador" +
                "\n(D)esligar colaborador");
            string op = Console.ReadLine();
            switch (op.ToUpper())
            {
                case "F":
                    AbrirConta();
                    break;
                case "E":
                    EncerrarConta();
                    break;
                case "C":
                    CadastraColaborador();
                    break;
                case "D":
                    DesligarColaborador();
                    break;

            }
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
