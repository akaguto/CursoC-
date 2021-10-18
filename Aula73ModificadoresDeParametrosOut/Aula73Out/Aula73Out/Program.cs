using System;

namespace Aula73Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            int triplo;
            Calculadora.Triplo(a, out triplo);
            Console.WriteLine(triplo);
        }
    }
}

//Tanto o REF quanto o OUT são considerados "code smells"(design ruim) e devem ser evitados.