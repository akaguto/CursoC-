using System;
using System.Globalization;

namespace AlunoNotaFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Console.WriteLine("Entre com os dados do aluno: ");
            Console.Write("Nome:");
            a1.Nome = Console.ReadLine();

            Console.Write("Nota primeiro Trimestre: ");
            a1.N1 = double.Parse(Console.ReadLine());
            Console.Write("Nota segundo Trimestre: ");
            a1.N2 = double.Parse(Console.ReadLine());
            Console.Write("Nota terceiro Trimestre: ");
            a1.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine(a1);
        }
    }
}
