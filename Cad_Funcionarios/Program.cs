using System;
using System.Collections.Generic;
using System.Globalization;


namespace Cad_Funcionarios
{
    class Program
    {
        //Programa simples de console para cadastrar e mostrar um número de funcionários determinado pelo usuário:
        static void Main(string[] args)
        {
            string cpf, nome;
            int flag = 1;
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

            while (flag == 1)
            {
                Console.WriteLine();
                Console.Write("Digite o CPF do funcionário que terá aumento: ");
                cpf = Console.ReadLine();
                int pos = funcionarios.FindIndex(x => x.Cpf == cpf);
                if (pos == -1)
                {
                    Console.WriteLine("CPF inválido!");
                }
                else
                {
                    Console.Write("Digite a porcentagem de aumento: ");
                    double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    funcionarios[pos].AumentarSalario(percentual);
                    flag = 0;
                }
            }
            

            Console.WriteLine();
            Console.WriteLine("Listagem atualizada de funcionários:");
            for (int i = 0; i < funcionarios.Count; i++)
            {
                Console.WriteLine(funcionarios[i]);
            }

            Console.ReadKey();
        }
    }
}
