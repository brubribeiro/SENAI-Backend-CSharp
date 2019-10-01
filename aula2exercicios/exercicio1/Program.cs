using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 1
            // Elabore um algoritmo que leia o salário digitado pelo usuário e também sua
            // despesa total, verificando se o saldo final é positivo (superávit) ou negativo
            // (déficit);

            double salario, despesa, saldo;
            bool resultado = false;
            string status;

            Console.WriteLine("Digite seu salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de despesas: ");
            despesa = double.Parse(Console.ReadLine());

            saldo = salario - despesa;

            if(saldo > 0){
                resultado = true;
            }
            if(resultado == true){
                status = "Seu saldo final é positivo!";
            }
            else
            {
                status = "Seu saldo final é negativo!";
            }
            Console.WriteLine(status);
        }
    }
}
