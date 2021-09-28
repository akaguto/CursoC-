using System;
using System.Globalization;

namespace EstoqueProduto
{
    class Program
    {
        static void Main(string[] args)
        {          
               
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o preco do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade no estoque: ");
            int qtEstoque = int.Parse(Console.ReadLine());

            Produto produto1 = new Produto(nome, preco, qtEstoque);
            Console.WriteLine(produto1);

            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            produto1.AddProdutos(int.Parse(Console.ReadLine()));            
            Console.WriteLine(produto1);

            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            produto1.RmProdutos(int.Parse(Console.ReadLine()));            
            Console.WriteLine(produto1);
        }
    }
}

