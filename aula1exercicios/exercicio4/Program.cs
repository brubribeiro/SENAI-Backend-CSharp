using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {   
            // //Elabore um algoritmo que efetue a apresentação da conversão de um valor em real (R$) para
            //  o valor em dólar (US$).O algoritmo deverá solicitar o valor da cotação do dólar.

            float cotacao, dolar, real;

            Console.WriteLine("Digite o valor em Real: ");
            real = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cotação do Dólar: ");
            cotacao = float.Parse(Console.ReadLine());

            dolar = real / cotacao;

            Console.WriteLine("O valor final é de " + dolar + " doláres");


        }
    }
}
