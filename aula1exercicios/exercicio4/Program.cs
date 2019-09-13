using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {   
            string nome;
            float cotacao, dolar, real;

            //Console.WriteLine("Bem vindo ao programa para conversão para dólar!");

            Console.WriteLine("Digite o valor em Real: ");
            real = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cotação do Dólar: ");
            cotacao = float.Parse(Console.ReadLine());

            dolar = real / cotacao;

            Console.WriteLine("O valor final é de " + dolar + " doláres");


        }
    }
}
