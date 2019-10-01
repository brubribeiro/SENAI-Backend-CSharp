using System;
using exercicio6.Models;

namespace exercicio6.Controllers
{
    public class PedidoController : PizzaController
    {
        PedidoModel pedido = new PedidoModel();
        PizzaModel pizza = new PizzaModel();

         public void CadastrarPedido(){
            System.Console.WriteLine("Digite o tipo da pizza? Salgada/Doce");
            pizza.Tipo = Console.ReadLine();
            System.Console.WriteLine("Digite o sabor: ");
            pizza.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite o preço: ");
            pizza.Preco = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o tamanho da pizza: Pequena, Média ou Grande");
            pizza.Tamanho = Console.ReadLine();
            System.Console.WriteLine("Digite o endereço de entrega: ");
            pedido.EnderecoEntrega = Console.ReadLine();
            pedido.DataPedido = DateTime.Now;
            pedido.PrevisaoEntrega = (DateTime.Now.AddMinutes(30));
        }
        public void LerPedido(){
            System.Console.WriteLine("Informações do pedido");
            System.Console.WriteLine($"Data do Pedido: {pedido.DataPedido}");
            System.Console.WriteLine($"Pizza: {pedido.Nome}");
            System.Console.WriteLine($"Tamanho: {pizza.Tamanho}");
            System.Console.WriteLine($"Preço: R$ {pizza.Preco}");
            System.Console.WriteLine($"Endereço de entrega: {pedido.EnderecoEntrega}");
            System.Console.WriteLine($"Previsão de entrega: {pedido.PrevisaoEntrega}");
        }
    }
}