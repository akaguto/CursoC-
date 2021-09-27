using System;
using System.Globalization;

namespace Cotacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double total;
            double qtComprar;
            Console.Write("Quantos dolares voce vai comprar: ");
            qtComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = Cotacao.Conversao(qtComprar);
            Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
