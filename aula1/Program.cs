using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Somente declaramos, sem atribuir valor
            int num1;
            //Declaramos atribuindo um valor
            int num2 = 5;
            //Declaramos diversas variaveis de mesmo tipo
            int num3, num4, num5;
            //Variavel do tipo decimal(real)
            float media;
            //Variavel do tipo lógico(booleana)
            bool resultado = false;
            //Variável do tipo texto(caracteres)
            string nomeAluno;

            //Quebra de linha
            Console.WriteLine();
            
            //Escreve em uma linha quebrando-a
            Console.WriteLine("Bem vindos à nossa primeira aplicação!");

            //Continua escrevendo na mesma linha
            Console.Write("Digite");
            Console.Write(" seu nome: ");

            //Capturo o dado digitado pelo usuário e salvo na variável
            nomeAluno = Console.ReadLine();

            //Concatenação
            Console.WriteLine(nomeAluno + ", agora digite sua primeira nota: ");
            num3 = int.Parse(Console.ReadLine());

            //Interpolação
            Console.WriteLine($"Sua primeira nota é {num3}");

            Console.Write("Digite sua segunda nota: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            num5 = int.Parse(Console.ReadLine());

            media = (num3 + num4 + num5)/3;

            Console.WriteLine("Sua média é " + media);

        }
    }
}
