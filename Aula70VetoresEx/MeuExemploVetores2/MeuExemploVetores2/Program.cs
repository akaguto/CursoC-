using System;
using System.Globalization;

namespace MeuExemploVetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0.0;
            double media;
            
            Console.Write("Digite a quantidade de produtos que deseja adicionar: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] produto = new Produto[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(" ");
                Console.Write("Informe o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o preco do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto[i] = new Produto(nome, preco);
            }

            for(int i = 0; i < n; i++)
            {
                soma += produto[i].Preco; 
            }

            media = soma / n;
            Console.WriteLine(" ");
            Console.WriteLine("O preço médio dos produtos é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
