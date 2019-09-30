using System;
using Senai.POO.Aluno.Controllers;

namespace Senai.POO.Aluno
{
    class Program
    {
        static void Main(string[] args)
        {   
            #region Cadastrando primeiro aluno
            // Declarando objeto
            AlunoController aluno = new AlunoController();

            //Limpa a tela
            Console.Clear();

            //Cadastrar o aluno no sistema
            aluno.CadastrarAluno();

            //Exibe o aluno no sistema
            aluno.ExibirAluno();

            //Chamando método do objeto
            aluno.IrNoBanheiro();
            #endregion

        }
    }
}
