using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploPraticoCSharp.Pessoas;

namespace ExemploPraticoCSharp.Funcionarios
{
    public abstract class Funcionario: Pessoa
    {
        private String departamento;
        private double salario;

        public Funcionario(string nome, string cPF, Endereco endereco, String departamento,double salario) : base(nome, cPF, endereco)
        {
            this.departamento = departamento;
            this.salario = salario;
        }

        public abstract void getBonificacao();
        public abstract void setAjusteDeSalario();


    }
}
