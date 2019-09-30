using System;
using aula10.Controllers;

namespace aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosController produto1 = new ProdutosController();

            produto1.CadastrarProduto();
            produto1.ExibirProduto();
        }
    }
}
