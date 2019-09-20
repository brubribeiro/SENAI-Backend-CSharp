using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dados dois vetores, A e B com 15 palavras, construa um terceiro vetor com os dados
            // dos vetores anteriores.

            string[] a = new string[15];
            string[] b = new string[15];
            string[] c = new string[30];

            for(int i = 0; i <= 14; i++){
                Console.Write("Vetor 1-Digite uma palavra: ");
                a[i] = Console.ReadLine();
            }

            for(int i = 0; i <=14; i++){
                Console.Write("Vetor 2-Digite uma palavra: ");
                b[i] = Console.ReadLine();
            }
            for(int i = 0; i <=14; i++){
                c[i] = a[i];
                c[i+15] = b[i];
            }
            for(int i = 0; i <=29; i++){
                Console.WriteLine(c[i]);
            }
        }
    }
}
