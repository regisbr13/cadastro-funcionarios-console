using System;
using System.Collections.Generic;
using System.Globalization;


namespace Cad_Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf, nome;
            double salario;
            
            Console.Write("Quantos funcionários serão cadastrados? ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Dados do " + i + "° funcionário:");
                Console.Write("CPF: ");
                cpf = Console.ReadLine();
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salário: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                List<Funcionario> funcionarios = new List<Funcionario>();
                funcionarios.Add(new Funcionario(cpf, nome, salario));
            }
        }
    }
}
