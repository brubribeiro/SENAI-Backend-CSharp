using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore um algoritmo que apresente os números inteiros de 1 a 100 elevados ao cubo (x³).

            double num;

            for(double cont = 1; cont <= 100; cont++){
                num = Math.Pow(cont,3);
                Console.WriteLine($"{cont} elevado ao cubo é {num}");
            }

        }
    }
}
