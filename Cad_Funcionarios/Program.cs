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
            List<Funcionario> funcionarios = new List<Funcionario>();

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
                Funcionario funcionario = new Funcionario(cpf, nome, salario);
                funcionarios.Add(funcionario);
            }

            Console.WriteLine();
            Console.Write("Digite o CPF do funcionário que terá aumento: ");
            cpf = Console.ReadLine();
            Console.Write("Digite a porcentagem de aumento: ");
            double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario.AumentarSalario(Funcionario.TeraAumento(cpf, funcionarios), percentual);

            Console.WriteLine("Listagem atualizada de funcionários:");
            for (int i = 0; i < funcionarios.Count; i++)
            {
                Console.WriteLine(funcionarios[i]);
            }

            Console.ReadKey();
        }
    }
}
