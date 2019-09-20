using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que leia os valores de dois vetores de 10 posições gere um terceiro
            // vetor de 20 posições que seja a união dos dois primeiros.

            string[] num1 = new string[10];
            string[] num2 = new string[10];
            string[] num3 = new string[20];

            for(int i = 0; i <= 9; i++){
                Console.Write("Vetor 1-Digite um número: ");
                num1[i] = Console.ReadLine();
            }

            for(int i = 0; i <=9; i++){
                Console.Write("Vetor 2-Digite um número: ");
                num2[i] = Console.ReadLine();
            }
            for(int i = 0; i <=9; i++){
                num3[i] = num1[i];
                num3[i+10] = num2[i];
            }
            for(int i = 0; i <=19; i++){
                Console.WriteLine(num3[i]);
            }
        }
    }
}
