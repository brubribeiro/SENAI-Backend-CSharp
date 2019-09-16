using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia três números inteiros e retorne o maior valor lido.

            int maior, num1, num2, num3;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            if(num1 > num2 && num1 > num3){
                maior = num1;
            }
            else if (num2 > num3){
                maior = num2;
            }
            else
            {
                maior = num3;
            }
            Console.WriteLine($"O maior número é {maior}");
        }
    }
}
