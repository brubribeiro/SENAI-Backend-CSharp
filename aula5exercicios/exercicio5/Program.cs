using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que gere um vetor de 10 posições sendo que seu conteúdo seja o
            // dobro de seu próprio índice.

            int[] num = new int[10];

            for(int i = 0; i <= 9; i++){
                num[i] = i * 2 ;
            }
            for(int i = 0; i <= 9; i++){
                Console.WriteLine(num[i]);
            }
        }
    }
}
