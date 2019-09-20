using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia um número n e imprima todos os múltiplos de 5, no intervalo de 1 a n.

            int n, n1, n2;
            int cont1 = 1, cont2 = 1;

            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            for(int cont = 1; cont <= n; cont++){
                if(cont % 5 == 0){
                    Console.WriteLine(cont);
                }
            }

            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());

            while(cont1 <= n1){
                if(cont1 % 5 == 0){
                    Console.WriteLine(cont1);
                }
                cont1 ++;
            }

            Console.WriteLine("Digite um número: ");
            n2 = int.Parse(Console.ReadLine());

            do{
                if(cont2 % 5 == 0){
                    Console.WriteLine(cont2);
                }
                cont2 ++;
                
            }while(cont2 <= n2);
        }
    }
}
