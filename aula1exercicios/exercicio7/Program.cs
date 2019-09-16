using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // O preço do vale transporte é de R$4,30. O motorista de um ônibus deseja
            // adquirir um programa que leia a quantidade de passageiros que entram no
            // ônibus e que depois calcule e escreva quanto de dinheiro ele terá arrecadado.
            // Considere que todos os passageiros irão pagar o vale transporte sem
            // descontos.

            int passageiros;
            double vale, resultado;

            vale = 4.30;

           Console.WriteLine("Digite a quantidade de passageiros: ");
           passageiros = int.Parse(Console.ReadLine());

           resultado = vale * passageiros;

           Console.WriteLine("O ônibus irá arrecadar "+resultado+" reais");
        }
    }
}
