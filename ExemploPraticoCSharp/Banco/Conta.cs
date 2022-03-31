using ExemploPraticoCSharp.Clientes;

namespace ExemploPraticoCSharp.Banco
{
    class Conta
    {
        public String IdConta { get;}
        private String agencia;
        private double _saldo;
        private Cliente cliente;

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
