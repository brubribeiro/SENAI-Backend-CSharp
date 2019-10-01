using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 2
            //Elabore um algoritmo que mostre o resultado da tabuada de um número inteiro dado
            // pelo usuário. O formato deve ser apresentado na forma: Exemplo, para o número 2:
            // 2 X 1 = 2
            // 2 X 2 = 4
            // (...)
            // 2 X 10 = 20
            int num, cont = 1;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            
            while(cont<=10){
                Console.WriteLine($"{num}X{cont}={num*cont}");
                cont ++;
            }

            int cont1 = 1;

            do{
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"{num}X{cont1}={num*cont1}");
                cont1 ++;
            }while(cont1<=10);
            

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            for(int cont2 = 1; cont2 <= 10; cont2++){
                Console.WriteLine($"{num}X{cont1}={num*cont2}");
            }
        }
    }
}
