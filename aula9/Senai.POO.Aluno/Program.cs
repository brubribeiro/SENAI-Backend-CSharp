using System;
using Senai.POO.Aluno.Models;

namespace Senai.POO.Aluno
{
    class Program
    {
        static void Main(string[] args)
        {   
            #region Cadastrando primeiro aluno
            // Declarando objeto
            AlunoModel aluno = new AlunoModel();

            //Cadastrar o aluno no sistema
            aluno.CadastrarAluno();

            //Exibe o aluno no sistema
            aluno.ExibirAluno();
            #endregion

            #region Cadastrando segundo aluno
            //Declarando objeto
            AlunoModel aluno2 = new AlunoModel();

            //Cadastrar o aluno2 no sistema
            aluno2.CadastrarAluno();

            //Exibe o aluno2 no sistema
            aluno2.ExibirAluno();                
            #endregion

        }
    }
}
