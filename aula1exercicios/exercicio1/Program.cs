using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           int num, resultado;

           Console.WriteLine("Bem vindo ao programa para multiplicar por 3!");

           Console.WriteLine("Digite o número a ser multiplicado: ");
           num = int.Parse(Console.ReadLine());

           resultado = num * 3;

           Console.WriteLine("O resultado da multiplicação é: " + resultado);
        }
    }
}
