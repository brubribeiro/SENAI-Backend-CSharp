using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Um vendedor ganha 5% de comissão sobre suas vendas. Considere um algoritmo que leia seu salário fixo, o total de vendas efetuadas e retorne o total que vendedor irá receber.

            double salario, tvendas, salariofinal, comissao;

            Console.WriteLine("Digite seu salario fixo: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas efetuadas: ");
            tvendas = double.Parse(Console.ReadLine());

            comissao = tvendas * 0.05;
            salariofinal = salario + comissao;

            Console.WriteLine("O total que irá receber é: " + salariofinal);

        }
    }
}
