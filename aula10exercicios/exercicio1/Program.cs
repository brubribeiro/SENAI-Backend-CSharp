using System;
using exercicio1.Controllers;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaController pessoa = new PessoaController();

            pessoa.CalcularIMC();
        }
    }
}
