using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar uma função do tipo double que recebe como argumentos valor e
            // porcentagem, onde o intuito é atribuir um desconto sobre a porcentagem 
            // e retornar o valor aplicado o desconto
            try{
            Console.Write("Digite o valor: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Digite o desconto %: ");
            double porcentagem = double.Parse(Console.ReadLine().Replace("%",""));

            System.Console.WriteLine("O valor com desconto é de R$" + CalculaDesconto(valor, porcentagem));
            }
            catch{
                System.Console.WriteLine("Ops...deu erro!");
            }

        }
        static double CalculaDesconto( double valor, double porcentagem){
            double desconto = 0;
            try{
            desconto = valor - valor * (porcentagem/100);
            }
            catch{
                System.Console.WriteLine("Ops...deu erro!");
            }
            return desconto;
        }
    }
}
