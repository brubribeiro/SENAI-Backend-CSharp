using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {   
            float custo, percentual, venda, porcentagem;

            //Console.WriteLine("Bem vindo ao programa para calculo de venda!");
            
            Console.WriteLine("Digite o preço de custo do produto: ");
            custo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de acréscimo: ");
            percentual = float.Parse(Console.ReadLine());

            porcentagem = percentual / 100;
            
            venda = (porcentagem * custo) + custo;

            Console.WriteLine("O valor de venda deste produto é: " + venda);

        }
    }
}
