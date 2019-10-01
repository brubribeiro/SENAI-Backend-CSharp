using System;

namespace exemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura Condicional
            string placa, resultado;
            string final;

            Console.Write("Digite a placa do seu carro: ");
            placa = Console.ReadLine();

            //Contamos a quantidade de caracteres de um elemento
            int caracteres = placa.Length;

            //Pegamos o último digito com o método Substring()
            final = placa.Substring(caracteres - 1);

            if(final == "1" || final == "2"){
                resultado = "IF/ELSE - Seu rodízio é na Segunda-Feira";
            }
            else if(final == "3" || final == "4"){
                resultado = "IF/ELSE - Seu rodízio é na Terça-Feira";
            }
            else if(final == "5" || final == "6"){
                resultado = "IF/ELSE - Seu rodízio é na Quarta-Feira";
            }
            else if(final == "7" || final == "8"){
                resultado = "IF/ELSE - Seu rodízio é na Quinta-Feira";
            }
            else if(final == "9" || final == "0"){
                resultado = "IF/ELSE - Seu rodízio é na Sexta-Feira";
            }
            else
            {
                resultado = "Placa inválida!";
            }
            Console.WriteLine(resultado);
        }
    }
}
