using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar um algoritmo que, se o preço total a ser pago for superior a R$ 100, então
            // subtraia R$25,00 do preço total.

            double total, resultado, desconto = 25.00;

            Console.WriteLine("Digite o valor total a ser pago: ");
            total = double.Parse(Console.ReadLine());

            if(total >= 100.00){
                resultado = total - desconto;
            }
            else{
                resultado = total;
            }
            Console.WriteLine($"O valor total a ser pago será de {resultado}");
        }
    }
}
