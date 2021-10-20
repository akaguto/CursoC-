using System;

namespace Aula75LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Pantera", "Tool", "Metallica" };

            Console.WriteLine("----//for//----");
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("\n----//foreach//----");                        
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}
