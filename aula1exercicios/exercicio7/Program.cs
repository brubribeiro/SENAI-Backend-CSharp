using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int passageiros;
            double vale, resultado;

            vale = 4.30;

           //Console.WriteLine("Bem vindo ao programa para calcular quanto o ônibus irá arrecadar de dinheiro pela quantidade de passageiros.");

           Console.WriteLine("Digite a quantidade de passageiros: ");
           passageiros = int.Parse(Console.ReadLine());

           resultado = vale * passageiros;

           Console.WriteLine("O ônibus irá arrecadar "+resultado+" reais");
        }
    }
}
