using System;

namespace BoxingEUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            Object obj = x; //Boxing: É o processo de conversão de um objeto tipo valor para um objeto tipo referência compatível.

            int y = (int) obj; //Unboxing: É o processo de conversão de um objeto tipo referência para um objeto tipo valor compatível.
            Console.WriteLine("Boxing: Obj = " + obj);
            Console.WriteLine("Unboxing: y = " + y);
        }
    }
}
