using System;

namespace RetanguloOp
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();
            
            Console.WriteLine("Entre com os valores do retangulo:");
            Console.Write("Largura : ");
            r1.L = double.Parse(Console.ReadLine());
            Console.Write("Altura : ");
            r1.A = double.Parse(Console.ReadLine());

            Console.WriteLine(r1);

        }
    }
}
