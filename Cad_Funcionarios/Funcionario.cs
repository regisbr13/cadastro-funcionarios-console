using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cad_Funcionarios
{
    class Funcionario
    {
        public string Cpf { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(string cpf, string nome, double salario)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Salario = salario;
        }

        public static Funcionario TeraAumento(string cpf, List<Funcionario> funcionarios)
        {
            int pos = funcionarios.FindIndex(x => x.Cpf == cpf);
            return funcionarios[pos];
        }

        public static void AumentarSalario(Funcionario funcionario, double percentual)
        {
            funcionario.Salario += funcionario.Salario * percentual / 100;
        }

        public override string ToString()
        {
            return Cpf + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
