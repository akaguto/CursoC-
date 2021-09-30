using System;
using System.Globalization;

namespace Aula69VetoresExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero de alturas que deseja armazenar: ");
            int n = int.Parse(Console.ReadLine());
            double[] alturas = new double[n];

            double soma = 0.0;

            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite a altura: ");
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            foreach(double altura in alturas)
            {
                soma += altura;
            }

            double media = soma / n;

            Console.WriteLine("A média das alturas é: " + media);
        }
    }
}
