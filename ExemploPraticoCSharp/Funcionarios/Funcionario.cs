using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploPraticoCSharp.Pessoas;

namespace ExemploPraticoCSharp.Funcionario
{
    public class Funcionario 
    {
        private String departamento;
        private double salario;

        public Funcionario(string nome, string cPF, Endereco endereco, String departamento,double salario) : base(nome, cPF, endereco)
        {
            this.departamento = departamento;
            this.salario = salario;
        }

    }
}
