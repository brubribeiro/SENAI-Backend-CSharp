using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, divida, sobra;

            //Console.WriteLine("Bem vindo ao programa para calcular a sobra do salário!");

            Console.WriteLine("Digite seu salario fixo: ");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de dividas: ");
            divida = float.Parse(Console.ReadLine());

            sobra = salario - divida;

            Console.WriteLine("Depois do pagamento das dívidas irá sobrar "+sobra+" reais");
        }
    }
}
