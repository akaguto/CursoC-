using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Sum(10, 20, 30, 30);
            Console.WriteLine(result);

            int result2 = Calculator.Sum(13, 20, 340, 40);
            Console.WriteLine(result2);
        }
    }
}
