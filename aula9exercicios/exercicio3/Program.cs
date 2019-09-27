using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar uma sobrecarga de métodos chamada MostraInfo onde:
            //a) 1 - Sem argumentos, escreve no console a razão social da escola Senai de Informática
            //b) 2 - Com dois argumentos, retorna seu nome é sobrenome
            //c) 3 - Com três argumentos, retorna sua idade, peso e altura
            
            try{
            Console.WriteLine(MostraInfo());
            string nome, sobrenome;

            System.Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            System.Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.WriteLine(MostraInfo(nome, sobrenome));
            
            int idade;
            double peso, altura;

            System.Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine(MostraInfo(idade, peso, altura));
            }
            catch{
                System.Console.WriteLine("Ops...deu erro!");
            }
        }
        static string MostraInfo(){
            return "Servico Nacional de Aprendizagem Industrial - SENAI de Informática";
        }
        static string MostraInfo(string nome, string sobrenome){
            return $"{nome} {sobrenome}";
        }
        static string MostraInfo(int idade, double peso, double altura){
            return $"Idade: {idade}, Peso: {peso}, Altura: {altura}";
        }
    }
}
