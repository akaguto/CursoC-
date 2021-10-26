using System;
// Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.
namespace Aula80ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with N valor: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n]; //Cria a matriz N por N na memória. 

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter with");
                string[] values = Console.ReadLine().Split(' '); //Lê a linha inteira e recorta baseado no espaço em branco.

                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]); //preenche as linhas e colunas com os valores do split de values, convertendo de string p/ int.
                }
            }

            // Diagonal principal da matriz

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            //Quantidade de numero negativo
            int count = 0;
            for (int i = 0; i < n; i++) 
            {
                for(int j = 0; j < n; j++)
                {                               // i e j vão percorrer toda a matriz
                    if(matriz[i,j] < 0)         // verifica se existe numero negativo na linha,coluna.
                    {
                        count++;
                    } 
                }
            }

            Console.WriteLine("Negative Numbers: " + count);
            
        }
    }
}
