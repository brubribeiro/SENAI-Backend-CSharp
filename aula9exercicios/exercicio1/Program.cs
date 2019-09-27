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
                System.Console.WriteLine("Os dados devem ser númericos!");
            }
        }
        /// <summary>
        /// Função que aplica desconto em cima de um valor
        /// </summary>
        /// <param name="valor">Preço da mercadoria</param>
        /// <param name="porcentagem">Percentual de desconto</param>
        /// <returns>Valor do preço com o desconto aplicado</returns>
        static double CalculaDesconto( double valor, double porcentagem){
            double desconto = 0;
            
            desconto = valor - valor * (porcentagem/100);
            
            return desconto;
        }
    }
}
