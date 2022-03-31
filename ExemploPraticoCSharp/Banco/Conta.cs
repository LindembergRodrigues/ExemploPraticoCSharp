using ExemploPraticoCSharp.Clientes;

namespace ExemploPraticoCSharp.Banco
{
    class Conta
    {
        public String IdConta { get;}
        public String agencia { get; }
        public double _saldo { get; }
        public Cliente cliente { get; }

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
    }
}
