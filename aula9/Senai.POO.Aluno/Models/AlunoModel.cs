using System;

namespace Senai.POO.Aluno.Models
{
    public class AlunoModel
    {
        /// <summary>
        /// Nome do Aluno
        /// </summary>
        /// <value>string</value>
        public string Nome {get;set;}

        /// <summary>
        /// Nome do Curso
        /// </summary>
        /// <value>string</value>
        public string Curso {get;set;}

        /// <summary>
        /// RA do aluno, identificado
        /// </summary>
        /// <value>string</value>
        public string RA {get;set;}

        /// <summary>
        /// Idade do Aluno
        /// </summary>
        /// <value>int</value>
        public int Idade {get;set;}

        /// <summary>
        /// Começar a estudar
        /// </summary>
        public void Estudar(){
            Console.WriteLine("Estou estudanto!");
        }

        /// <summary>
        /// Pede café para o professor
        /// </summary>
        public void PedirIntervalo(){
            Console.WriteLine("Pode fazer intervalo aeee!");
            Console.WriteLine("QUERO CAFÉ!!");
        }

        /// <summary>
        /// Pedir ajuda para o professor
        /// </summary>
        public void PedirAjuda(){
            Console.WriteLine("Ô Paulo, chega ae!!");
        }

        public void CadastrarAluno(){

            System.Console.WriteLine("Insira seu nome: ");
            Nome = Console.ReadLine();

            System.Console.WriteLine("Insira o nome do seu curso: ");
            Curso = Console.ReadLine();
            
            System.Console.WriteLine("Insira seu RA: ");
            RA = Console.ReadLine();
            
            System.Console.WriteLine("Insira sua idade: ");
            Idade = int.Parse(Console.ReadLine());
        }

        public void ExibirAluno(){
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Curso: " + Curso);
            System.Console.WriteLine("RA: " + RA);
            System.Console.WriteLine("Idade: " + Idade);
        }
    }
}