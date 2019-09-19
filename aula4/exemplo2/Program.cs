using System;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAÇO CONDICIONAL - WHILE
            //Elabore um algoritmo que leia a nota dos alunos e calcule a média

            double nota = 0;
            double acm = 0;
            int cont = 0;
            string sair = "";

            while(sair != "sim"){
                Console.Write("Digite a nota de um aluno: ");
                nota = double.Parse(Console.ReadLine());

                acm += nota;
                cont ++;

                Console.Write("Deseja sair da aplicação? sim/não ");  
                sair = Console.ReadLine().ToLower();              
            }
            Console.WriteLine("A média das notas é de " + (acm/cont));
        }
    }
}
