using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {   
            double salario, tvendas, salariofinal, comissao;

            //Console.WriteLine("Bem vindo ao programa para calculo de comissão!");

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
