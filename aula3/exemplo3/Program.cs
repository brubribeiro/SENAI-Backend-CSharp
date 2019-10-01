using System;

namespace exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura de Escolha(CASO)
            //Faça um algoritmo que leia seu peso no planeta terra, que leia também o número de um
            // planeta conforme tabela ao lado e calcule seu peso neste planeta:

            double peso, resultado;
            string planeta;

            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha um planeta: 1 - Mercúrio, 2 - Vênus, 3 - Marte, 4 - Júpiter, 5 - Saturno ou 6 - Urano");
            planeta = Console.ReadLine();

            switch(planeta){
                case "1":
                resultado = peso * 0.37;
                Console.WriteLine($"Seu peso em Mércurio é de {resultado}kg");
                break;

                case "2":
                resultado = peso * 0.88;
                Console.WriteLine($"Seu peso em Vênus é de {resultado}kg");
                break;

                case "3":
                resultado = peso * 0.38;
                Console.WriteLine($"Seu peso em Marte é de {resultado}kg");
                break;

                case "4":
                resultado = peso * 2.64;
                Console.WriteLine($"Seu peso em Júpiter é de {resultado}kg");
                break;

                case "5":
                resultado = peso * 1.15;
                Console.WriteLine($"Seu peso em Saturno é de {resultado}kg");
                break;

                case "6":
                resultado = peso * 1.17;
                Console.WriteLine("Seu peso em Urano é de" + resultado +"kg");
                break;

                default:
                Console.WriteLine("Planeta inválido!!");
                break;
            } 
        }
    }
}
