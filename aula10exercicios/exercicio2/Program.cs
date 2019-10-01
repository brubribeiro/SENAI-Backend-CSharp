using System;
using exercicio2.Controllers;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoController aluno = new AlunoController();

            aluno.CadastrarAluno();

            aluno.ExibirAluno();
        }
    }
}
