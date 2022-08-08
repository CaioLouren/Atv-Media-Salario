using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salario: ");
            double salario = double.Parse(Console.ReadLine());
            Funcionario funcionario = new Funcionario(nome, salario);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Salario: ");
            salario = double.Parse(Console.ReadLine());
            Funcionario funcionario2 = new Funcionario(nome, salario);

            Console.WriteLine("Salário médio = " + funcionario.Media(funcionario, funcionario2).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
