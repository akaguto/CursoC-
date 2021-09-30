using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double? x = null;
            double? y = 10.0;
            /*
                        Console.WriteLine(x.GetValueOrDefault());
                        Console.WriteLine(y.GetValueOrDefault());

                        Console.WriteLine(x.HasValue);
                        Console.WriteLine(y.HasValue);

                        if (x.HasValue)
                            Console.WriteLine(x.Value);
                        else
                            Console.WriteLine("X is Null");

                        if (y.HasValue)
                            Console.WriteLine(y.Value);
                        else
                            Console.WriteLine("Y is Null");
            */

            double a = x ?? 5; //Define o valor de a como o de x, caso o valor de x seja nulo, define o valor de a como 5.
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
//Nullable
//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/default-value-expressions

//Operador de Coalescência nula:
//https://docs.microsoft.com/en-us/dotnet/csharp/languagereference/operators/null-conditional-operator

