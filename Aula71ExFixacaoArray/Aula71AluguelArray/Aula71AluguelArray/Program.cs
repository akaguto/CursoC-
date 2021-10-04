using System;
using System.Globalization;

namespace Aula71AluguelArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Quarto[] quarto = new Quarto[11];
            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o numero do quarto que será alugado: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Informe o nome do cliente: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o E-mail do cliente: ");
                string email = Console.ReadLine();
                Console.WriteLine(" ");

                quarto[numero] = new Quarto(nome, email, numero);
            }

            for (int i = 1; i < 11; i++)
                if (quarto[i] != null)
                {
                    Console.WriteLine("Aluguel #" + i);
                    Console.WriteLine(quarto[i]);
                    Console.WriteLine("");
                }
            Console.WriteLine(" ");
        }
    }
}
