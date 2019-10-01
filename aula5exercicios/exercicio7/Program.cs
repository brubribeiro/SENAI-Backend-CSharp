using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Faça um algoritmo que leia os valores de um vetor de 10 posições e que apresente o
            // maior valor digitado e em qual posição ele se encontra.

            int maior = 0;
            int posicao = 0;

            int[] num = new int[10];
            
            for(int i = 0; i<=9; i++){
                Console.WriteLine("Digite um número: ");
                num[i] = int.Parse(Console.ReadLine());

                if(i == 0){
                    maior = num[i];
                }

                if(num[i] > maior){
                    maior = num[i];
                    posicao = i;
                }
            }
            Console.WriteLine($"Maior: {maior}, Posição: {posicao}");    
        }
    }
}
