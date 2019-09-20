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

            int cont = 1;
            int acum = 0;
            int num;

            while(cont<=10){
                Console.WriteLine($"A - Digite o número {cont}: ");
                num = int.Parse(Console.ReadLine());

                if(cont % 2 != 0){
                    acum = acum + cont;
                }
                cont ++;
            }
            Console.WriteLine($"A soma dos números impares é de {acum}");
        }
    }
}
