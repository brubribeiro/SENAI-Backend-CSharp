using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia dois números inteiros e retorne o maior valor lido.

            int num1, num2, resultado;
            
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 > num2){
                resultado = num1;
            }
            else
            {
                resultado = num2;
            }
            Console.WriteLine(resultado);
        }
    }
}
