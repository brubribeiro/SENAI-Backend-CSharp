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
            
            
            Console.WriteLine(MostraInfo());
            string nome, sobrenome, idade, peso, altura;

            System.Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            System.Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.WriteLine(MostraInfo(nome, sobrenome));

            System.Console.WriteLine("Digite sua idade: ");
            idade = Console.ReadLine();

            System.Console.WriteLine("Digite seu peso: ");
            peso = Console.ReadLine();

            System.Console.WriteLine("Digite sua altura: ");
            altura = Console.ReadLine();

            Console.WriteLine(MostraInfo(idade, peso, altura));
                        
        }
        static string MostraInfo(){
            return "Servico Nacional de Aprendizagem Industrial - SENAI de Informática";
        }
        static string MostraInfo(string nome, string sobrenome){
            return $"{nome} {sobrenome}";
        }
        static string MostraInfo(string idade, string peso, string altura){
            return $"Idade: {idade}, Peso: {peso}Kg, Altura: {altura}";
        }
    }
}
