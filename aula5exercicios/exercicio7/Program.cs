using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que leia os valores de um vetor de 10 posições e que apresente o
            // maior valor digitado e em qual posição ele se encontra.

            int[] num = new int[10];
            
            for(int i = 0; i<=9; i++){
                Console.WriteLine("Digite um número: ");
                num[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
