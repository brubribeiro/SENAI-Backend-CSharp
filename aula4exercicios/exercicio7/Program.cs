using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elabore um algoritmo que leia 100 números inteiros, maiores que zero e imprima os
            // seguintes resultados:
            // a) A soma de todos os números impares;
            // b) O produto de todos os números múltiplos de 3.

            int cont = 1, cont1 = 1;
            int acum = 0, prod = 1;
            int num, num1;

            while(cont<=10){
                Console.WriteLine($"A - Digite o número {cont}: ");
                num = int.Parse(Console.ReadLine());

                if(num % 2 != 0){
                    acum = acum + num;
                }
                cont ++;
            }
            Console.WriteLine($"A soma dos números impares é de {acum}");

            while(cont1<=10){
                Console.WriteLine($"B - Digite o número {cont1}: ");
                num1 = int.Parse(Console.ReadLine());

                if(num1 % 3 == 0){
                    prod = prod * num1;
                }
                cont1 ++;
            }
            Console.WriteLine($"O produto dos números multiplos de 3 é {prod}");
        }
    }
}
