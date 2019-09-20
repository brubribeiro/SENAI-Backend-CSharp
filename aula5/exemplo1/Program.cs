using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] media = new double[10];

            for(int i = 0; i <= 9; i++){
                Console.Write("Digite uma média: ");
                media[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(media[3]);

            for(int i = 0; i <= media.Length - 1; i++){
                Console.WriteLine("Média: " + media[i]);
            }
        }
    }
}
