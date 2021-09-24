using System;
using System.Globalization;

namespace EstoqueProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Produto product1 = new Produto();
            
            Console.WriteLine("Digite o nome do produto: ");
            product1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preco do produto: ");
            product1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade no estoque: ");
            product1.QtEstoque = int.Parse(Console.ReadLine());
            
            Console.WriteLine(product1);

            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            product1.AddProdutos(int.Parse(Console.ReadLine()));            
            Console.WriteLine(product1);

            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            product1.RmProdutos(int.Parse(Console.ReadLine()));            
            Console.WriteLine(product1);
        }
    }
}

