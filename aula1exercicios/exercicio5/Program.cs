using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Exercicio 5
            //Escreva um algoritmo que leia o nome de um vendedor, o seu salário fixo e o
            //total de vendas efetuadas por ele no mês (em dinheiro). O vendedor ganha 10%
            //de comissão sobre suas vendas efetuadas. Exiba, o nome, o salário fixo e salário
            //final do mês do vendedor.
            
            string nomefunc;
            double salario, tvendas, salariofinal, comissao;

            Console.WriteLine("Digite nome do vendedor: ");
            nomefunc = Console.ReadLine();

            Console.WriteLine("Digite seu salario fixo: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas efetuadas: ");
            tvendas = double.Parse(Console.ReadLine());

            comissao = tvendas * 0.10;
            salariofinal = salario + comissao;

            Console.WriteLine("O vendedor(a) "+nomefunc+" tem o salário de "+salario+", com a comissão de vendas irá receber " + salariofinal);
        }
    }
}
