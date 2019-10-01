using System;

namespace exercicio6.Models
{
    public class PedidoModel : PizzaModel
    {
        public DateTime DataPedido { get; set; }

        public string EnderecoEntrega { get; set; }

        public DateTime PrevisaoEntrega { get; set; }

        public PizzaModel Pizza { get; set; }
    }
}