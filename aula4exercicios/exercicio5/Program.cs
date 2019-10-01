using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 5
            // Uma empresa com X funcionários precisa saber a média de seus salários. Faça um
            // algoritmo para ler a quantidade de funcionários e o salário de cada um e escrever a
            // média dos salários.

            int funcionarios;
            double salario, acum = 0;
            int cont = 1;

            Console.WriteLine("Digite a quantidade de funcionarios: ");
            funcionarios = int.Parse(Console.ReadLine());

            while(cont<=funcionarios){
                Console.WriteLine($"Digite o salário {cont}: ");
                salario = double.Parse(Console.ReadLine());
                acum = acum + salario;
                cont ++;
            }
            Console.WriteLine($"A média dos salários é de {acum/funcionarios}");
        }
    }
}
