using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Um site na web precisa registrar 12 produtos de um fornecedor, crie um vetor para
            // representar estes produtos com os seguintes atributos: Nome do produto, Cor,
            // Tamanho e Preço.

            string[] nomeprod = new string[12];
            string[] cor      = new string[12];
            string[] tamanho  = new string[12];
            double[] preco    = new double[12];

            for(int i =0; i <= 11; i++){
                Console.WriteLine("Digite o nome do produto: ");
                nomeprod[i] = Console.ReadLine();
                Console.WriteLine("Digite a cor do produto: ");
                cor[i] = Console.ReadLine();
                Console.WriteLine("Digite o tamanho do produto(P,M,G): ");
                tamanho[i] = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto: ");
                preco[i] = double.Parse(Console.ReadLine());
            }
            for(int i =0; i <= 11; i++){
                Console.WriteLine($"Nome do produto: {nomeprod[i]}");
                Console.WriteLine($"Tamanho: {tamanho[i]}");
                Console.WriteLine($"Cor: {cor[i]}");
                Console.WriteLine($"Preço: {preco[i]}");
            }
        }
    }
}
