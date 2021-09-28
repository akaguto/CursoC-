using System;
using System.Globalization;

namespace S5ExercicioConta
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroConta;
            string nome;
            char condicao;
            double deposito;

            Conta cliente1;
            Console.WriteLine("Digite os dados da conta: ");
            Console.Write("Número da conta: ");
            numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial: (s/n)?");
            condicao = char.Parse(Console.ReadLine());

            if(condicao == 's' || condicao == 'S')
            {
                Console.Write("Valor de deposito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente1 = new Conta(numeroConta, nome, deposito);
            }
            else
            {
                deposito = 0.0;
                cliente1 = new Conta(numeroConta, nome, deposito);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cliente1);

            Console.WriteLine(" ");
            Console.Write("Entre com um valor para o depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente1.Deposita(valor);
            Console.WriteLine(" ");
            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(cliente1);

            Console.WriteLine(" ");
            Console.Write("Entre com um calor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta Atualizados: ");
            cliente1.Saca(valor);
            Console.WriteLine(cliente1);
        }
    }
}
