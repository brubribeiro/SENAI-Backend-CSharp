using System;
using exercicio6.Controllers;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaController pizza = new PizzaController();
            PedidoController pedido = new PedidoController();

            Console.Clear();
            pedido.CadastrarPedido();
            System.Console.WriteLine();
            pedido.LerPedido();
        }
    }
}
