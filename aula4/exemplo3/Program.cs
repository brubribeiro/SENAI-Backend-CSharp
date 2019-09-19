using System;

namespace exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia 20 números inteiros e acumule apenas os números múltiplos de 3
            int num, cont = 1, acum =0;
        
            do{
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                if(num % 3 == 0){
                    acum += num;
                }
                cont ++;
            }
            while(cont <= 20);

            Console.WriteLine(acum);
        }
    }
}
