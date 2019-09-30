using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que gere 20 números da série Fibonacci (0, 1, 1, 2, 3, 5, 8, 13, 21...).

            int num1 = 0, num2 = 1;
            
            for(int cont = 1;cont <= 10; cont ++){
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                num1 = num1 + num2;
                num2 = num2 + num1;
            }
        }
    }
}
