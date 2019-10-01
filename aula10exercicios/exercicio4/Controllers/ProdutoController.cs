using System;
using exercicio4.Models;

namespace exercicio4.Controllers
{
    public class ProdutoController
    {
        ProdutoModel produto = new ProdutoModel();

        public void CadastrarProduto(){
            System.Console.WriteLine("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite uma descrição para o produto: ");
            produto.Descricao = Console.ReadLine();
            System.Console.WriteLine("Você deseja reservar este produto?");
            produto.Reserva = bool.Parse(Console.ReadLine());

            if(produto.Reserva == true){
                System.Console.WriteLine("Produto reservado!");
            }else{
                System.Console.WriteLine("Produto não reservado!");
            }
            
        }
    }
}