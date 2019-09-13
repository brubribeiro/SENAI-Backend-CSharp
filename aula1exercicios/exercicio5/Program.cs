using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {   
            string nomefunc;
            double salario, tvendas, salariofinal, comissao;

            //Console.WriteLine("Bem vindo ao programa para conversão para dólar!");
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
