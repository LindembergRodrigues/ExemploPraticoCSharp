using ExemploPraticoCSharp.Clientes;

namespace ExemploPraticoCSharp.Banco
{
    class Conta
    {
        public String IdConta { get;}
        public String agencia { get; }
        public double _saldo { get; private set; }
        public Cliente cliente { get; }

        public Conta()
        {

        }
        public Conta(String agencia, string IdConta)
        {
            this.agencia = agencia;
            this.IdConta = IdConta;
        }

        public Conta(String agencia, string IdConta, Cliente novoCliente, double saldo = 0)
        {
            this.agencia = agencia;
            this.IdConta = IdConta;
            cliente = novoCliente;
            _saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (_saldo - valor >= 0)
            {
                _saldo -= valor;
            }
        }

        public void Transferir(double valor, Conta conta)
        {
            if (valor > 0)
            {
                conta.Depositar(valor);
                Sacar(valor);
            }
        }

        public override bool Equals(object obj)
        {
            Conta conta = obj as Conta;
            if (conta == null)
                return false;

            return conta.agencia == agencia && conta.IdConta == IdConta ;
        }

        public override string ToString()
        {
            return $"Olá {cliente.ToString} ";
        }
    }
}
