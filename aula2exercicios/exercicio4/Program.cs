using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se o preço total a ser pago ficar entre 100 e 1000, então forneça um desconto
            // de 15%.

            double total, resultado, desconto = 0.15;

            Console.WriteLine("Digite o valor total a ser pago: ");
            total = double.Parse(Console.ReadLine());

            if(total >= 100 && total <= 1000){
                resultado = total - (total * desconto);
            }
            
            Console.WriteLine("O valor total a ser pago é de " + resultado);
        }
    }
}
