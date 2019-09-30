using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //Faça um algoritmo para solicitar ao usuário um número, calcular e mostrar o seu triplo.
           int num, resultado;

           Console.WriteLine("Bem vindo ao programa para multiplicar por 3!");

           Console.WriteLine("Digite o número a ser multiplicado: ");
           num = int.Parse(Console.ReadLine());

           resultado = num * 3;

           Console.WriteLine("O resultado da multiplicação é: " + resultado);
        }
    }
}
