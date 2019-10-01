using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 4
            // Se o preço total a ser pago ficar entre 100 e 1000, então forneça um desconto
            // de 15%.

            double resultado, total, desconto = 0.15;

            Console.WriteLine("Digite o valor total a ser pago: ");
            total = double.Parse(Console.ReadLine());

            if(total >= 100 && total <= 1000){
                resultado = total - (total * desconto);
            }
            else
            {
                resultado = total;
            }
            
            Console.WriteLine($"O valor total a ser pago é de {resultado}");
        }
    }
}
