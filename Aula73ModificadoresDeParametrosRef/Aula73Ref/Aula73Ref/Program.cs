using System;

namespace Aula73Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            Calculator.Triplo(ref a);
            Console.WriteLine(a);
        }
    }
}
//Tanto o REF quanto o OUT são considerados "code smells"(design ruim) e devem ser evitados.