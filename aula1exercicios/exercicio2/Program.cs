using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Exercicio 2
            //Elabore um algoritmo que leia o preço de custo de uma mercadoria e um percentual de acréscimo para exibição do valor de venda desta mercadoria.

            float custo, percentual, venda, porcentagem;
            
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
