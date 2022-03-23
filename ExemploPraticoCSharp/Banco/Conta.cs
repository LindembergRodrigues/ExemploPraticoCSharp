using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPraticoCSharp.Banco
{
    class Conta
    {

        
        private double _saldo;

        public double Saldo {
            get { 
                return _saldo;
            }
            set {
                if (value > 0)
                {
                    _saldo += value;
                }
            }
        }
        public String Agencia { get; set; }
        public int Id { get; set; }
        public int TipoConta { get; set; }
        public Conta(String agencia, int id, double saldo, int tipoConta)
        {
            Agencia = agencia;
            Id = id;
            Saldo = saldo;
            TipoConta = tipoConta;
        }

        public void Depositar(double saldo)
        {
            Saldo = saldo;
        }
        
        public void Sacar(double saldo)
        {
            if(Saldo - saldo > 0)
            {
                Saldo -= saldo;
            }
        }
    }
}
