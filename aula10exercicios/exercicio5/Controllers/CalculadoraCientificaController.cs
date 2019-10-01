using System;
using exercicio5.Models;

namespace exercicio5.Controllers
{
    public class CalculadoraCientificaController : CalculadoraController
    {
        CalculadoraCientificaModel calculadoraCientifica = new CalculadoraCientificaModel();

        public void CalculadoraCientifica(){
            string escolha;

            Console.WriteLine("Escolha uma operação: 1 - Somar, 2 - Subtrair, 3 - Multiplicar, 4 - Dividir, 5 - Potência");
            escolha = Console.ReadLine();

            switch(escolha){
                case "1":
                    Somar();
                break;
                case "2":
                    Subtrair();
                break;
                case "3":
                    Multiplicar();
                break;
                case "4":
                    Dividir();
                break;
                case "5":
                    Potencia();
                break;
                default:
                    System.Console.WriteLine("Opção inválida!");
                break;
            }

        }

        public void Potencia(){
            System.Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            calculadoraCientifica.Potencia = 0;
            calculadoraCientifica.Potencia = Math.Pow(num1, num2);
            System.Console.WriteLine($"{num1}^{num2} = {calculadoraCientifica.Potencia}");
        }

    }
}