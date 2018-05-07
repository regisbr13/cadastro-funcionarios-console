using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cad_Funcionarios
{
    class Funcionario
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string cpf, string nome, double salario)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Salario = salario;
        }
    }
}
