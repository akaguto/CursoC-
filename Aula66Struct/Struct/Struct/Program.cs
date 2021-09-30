using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 10; // inicialização
            p.Y = 20; // inicialização
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);
        }
    }
}

// Classes:
// Classes são tipos referência. São ponteiros para caixas.
// (stack(endereço, aponta para o endereço da memória do objeto) ----> heap(objeto, endereço da memória))
// ex: p1 = p2 
// p2 vai apontar para o endereço de memória heap do p1.
//
// Structs:
// Struct é um tipo valor; Structs são caixa e não ponteiros. São tipos básicos da linguagem, por ex: int.
// ex: y = x
// y vai receber uma cópia de x. ambos na memória stack.
// É possível criar seus próprios structs.
// A variável precisa ser inicializada. L. 10 e 11.
// 