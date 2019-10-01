using System;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura de Escolha(CASO)
            //Faça um algoritmo que leia o número de um pedido de um cliente

            string pedido, resultado;

            Console.Write("Digite o número do pedido de 1 a 4: ");
            pedido = Console.ReadLine();

            switch(pedido){
                case "1":
                resultado = "Hamburguer";
                break;

                case "2":
                resultado = "Cheese Salada";
                break;

                case "3":
                resultado = "Cheese Burguer";
                break;

                case "4":
                resultado = "Cheese Bacon";
                break;

                default:
                resultado = "Opção inválida!";
                break;
            }
            Console.WriteLine(resultado);
        }
    }
}
