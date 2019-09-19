using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAÇO CONTADO - FOR - INCREMENTO (+)
            //Elabore um algoritmo que exiba na tela os números ímpares de 1 até 100.

            for(int cont = 1; cont <= 100; cont++){
                //Verificamos se o número é diferente de par
                if(cont % 2 != 0){
                    Console.WriteLine("FOR 0-100/" + cont);
                }
            }

            //LAÇO CONTADO - FOR - DECREMENTO (-)
            for(int cont = 100; cont >= 0; cont--){
                //Verificamos se o número é diferente de par
                if(cont % 2 != 0){
                    Console.WriteLine("FOR 100-0/" + cont);
                }
            }
        }
    }
}
