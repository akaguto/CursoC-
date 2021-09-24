using System;
using System.Globalization;

namespace ExercicioSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Console.WriteLine("Entre com os dados do funcionario: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + f1);

            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            f1.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados Atualizados: " + f1);
        }
    }
}
