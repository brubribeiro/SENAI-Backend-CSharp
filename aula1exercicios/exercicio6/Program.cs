using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 6
            // Sabendo que uma pessoa recebe um salário fixo por mês e que ele tem contas
            // a pagar, faça um algoritmo que leia o salário que ela recebe por mês e leia
            // também a dívida que possui. Por fim calcule e escreva quanto vai sobrar do
            // salário dela depois de pagar a dívida.

            float salario, divida, sobra;

            Console.WriteLine("Digite seu salario fixo: ");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de dividas: ");
            divida = float.Parse(Console.ReadLine());

            sobra = salario - divida;

            Console.WriteLine("Depois do pagamento das dívidas irá sobrar "+sobra+" reais");
        }
    }
}
