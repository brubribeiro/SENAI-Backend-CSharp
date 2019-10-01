using System;
using System.IO;
using exercicio1.Models;

namespace exercicio1.Controllers
{
    public class PessoaController
    {
        PessoaModel pessoa = new PessoaModel();

        public void CalcularIMC(){
            try{
                System.Console.WriteLine("Digite seu nome: ");
                pessoa.Nome = Console.ReadLine();

                System.Console.WriteLine("Digite seu peso: ");
                pessoa.Peso = double.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite sua altura: ");
                pessoa.Altura = double.Parse(Console.ReadLine());

                double imc = pessoa.Peso/(Math.Pow(pessoa.Altura, 2));

                if(imc < 18.5){
                    System.Console.WriteLine("Abaixo do peso!");
                }else if(imc >= 18.5 && imc <= 25){
                    System.Console.WriteLine("Peso normal!");
                }else if(imc >= 26 && imc <= 30){
                    System.Console.WriteLine("Sobrepeso!");
                }else if(imc >= 31 && imc <= 35){
                    System.Console.WriteLine("Obesidade grau 1");
                }else if(imc >= 36 && imc <= 39){
                    System.Console.WriteLine("Obesidade grau 2");
                }else{
                    System.Console.WriteLine("Obesidade grau 3");
                }

            }catch (Exception ex){
                System.Console.WriteLine("Desculpe! :( Houve um erro na aplicação!");
                SalvarErros(ex);
            }
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