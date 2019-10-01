using System;
using exercicio4.Controllers;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();

            produto.CadastrarProduto();
        }
    }
}
