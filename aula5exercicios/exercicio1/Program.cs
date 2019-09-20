using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia os valores de 10 posições e exiba o vetor e sua última posição multiplicada por 5.

            int[] num = new int[10];

            for(int i = 0; i <= 9; i++){
                Console.Write("Digite um número: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i <= 9; i++){
                Console.WriteLine(num[i]);
            }
            Console.WriteLine($"A ultima posição multiplicada por 5 é: {num[9]*5}");
        }
    }
}
