using System;

namespace exercicio5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("O valor total é: " + ValorTotal());
        }
        static double ValorTotal(double[] vetor){
            
            double total = 0;
            foreach(double numero in vetor){
                total += numero;
            }
            return total;
        }
    }
}
