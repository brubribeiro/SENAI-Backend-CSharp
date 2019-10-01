using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 6
            //Faça um algoritmo que recebe a idade do usuário e o classifica no sistema
            //ESRB-Games (pesquisem a respeito);

            int idade;

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 3 && idade < 6){
                Console.WriteLine("Early Childhood (EC) - PRIMEIRA INFÂNCIA");
            }
            else if(idade >= 6 && idade < 10){
                Console.WriteLine("Everyone (E) - TODOS");
            }
            else if(idade >= 10 && idade < 13){
                Console.WriteLine("Everyone 10+ (E10+) - TODOS 10+");
            }
            else if(idade >= 13 && idade < 17){
                Console.WriteLine("Teen (T) - ADOLESCENTE");
            }
            else if(idade >= 17 && idade < 18){
                Console.WriteLine("Mature (M) - MADURO");
            }
            else if(idade >= 18)
            {
                Console.WriteLine("Adults Only (AO) - ADULTOS SOMENTE");
            }
            else
            {
                Console.WriteLine("Rating Pending - CLASSIFICAÇÃO PENDENTE");
            }
        }
    }
}
