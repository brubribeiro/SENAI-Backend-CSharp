using System;

namespace exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura Condicional
            //Deixamos declarada como falsa por padrão
            bool entrada = false;
            int idade;
            string retorno;

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            /* Como já atribuímos anteriormente, mudamos o estado da variável para verdadeira
            caso entre nessa condição */
            if(idade > 17){
                entrada = true;
            }
            
            if(entrada == true){
                retorno = "Entrada permitida";
            }
            else
            {
                retorno = "Entrada não permitida";
            }
            
            Console.WriteLine(retorno);
        }
    }
}
