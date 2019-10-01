using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Exercicio 4
            // Dado um conjunto de 20 valores, faça um algoritmo que:
            // a) Imprima os valores que não são negativos.
            // b) Calcule e imprima a média dos valores < 0.

            int num;
            int contn = 0;
            int acum = 0, cont = 1;
           
            while(cont<=20){
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if(num < 0){
                    acum = acum + num;
                    contn = contn + 1;
                }
                else
                {
                    Console.WriteLine(num);
                }
                cont ++;
            }
            Console.WriteLine($"A média dos valores negativos é de {acum/contn}");
        }
    }
}
