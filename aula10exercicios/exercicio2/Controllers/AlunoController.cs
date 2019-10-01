using System;
using System.IO;
using exercicio2.Models;

namespace exercicio2.Controllers
{
    public class AlunoController
    {
        AlunoModel aluno = new AlunoModel();

        public void CadastrarAluno(){
            try{
                aluno.Bolsista = true;

                System.Console.WriteLine("Insira seu nome:");
                aluno.Nome = Console.ReadLine();
                
                System.Console.WriteLine("Insira o nome de seu curso: ");
                aluno.Curso = Console.ReadLine();
                        
                System.Console.WriteLine("Insira sua idade: ");
                aluno.Idade = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Insira seu RG: ");
                aluno.Rg = Console.ReadLine();

                System.Console.WriteLine("Possui bolsa de estudos? Sim/Não");
                aluno.Bolsista = bool.Parse(Console.ReadLine());
                

            }catch (Exception ex){
                System.Console.WriteLine("Desculpe! :( Houve um erro na aplicação!");
                SalvarErros(ex);
            }
        }
        public void ExibirAluno () {
            System.Console.WriteLine ("Nome: " + aluno.Nome);
            System.Console.WriteLine ("Curso: " + aluno.Curso);
            System.Console.WriteLine ("Idade: " + aluno.Idade);
            System.Console.WriteLine ("RG: " + aluno.Rg);
            System.Console.WriteLine("Bolsista: " + aluno.Bolsista);
        }

        private void SalvarErros(Exception ex){
            StreamWriter txt = new StreamWriter("error_log.txt", true);
            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex);
            txt.WriteLine();
            txt.Close();
        }
    }
}