using System;
using exercicio5.Controllers;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraController calculadora = new CalculadoraController();
            CalculadoraCientificaController calculadoraCientifica = new CalculadoraCientificaController();

            Console.Clear();

            Console.WriteLine("Escolha uma calculadora: \n 1 - Calculadora Simples \n 2 - Calculadora Científica");
            string escolha = Console.ReadLine();

            switch(escolha){
                case "1":
                    calculadora.Calculadora();
                break;
                case "2":
                    calculadoraCientifica.CalculadoraCientifica();
                break;
                default:
                    System.Console.WriteLine("Opção inválida!");
                break;
            }

        }
    }
}
