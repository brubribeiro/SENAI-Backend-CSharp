﻿using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura de Escolha(CASO)
            string placa, resultado;
            string final;

            Console.Write("Digite a placa do seu carro: ");
            placa = Console.ReadLine();

            //Contamos a quantidade de caracteres de um elemento
            int caracteres = placa.Length;

            //Pegamos o último digito com o método Substring()
            final = placa.Substring(caracteres - 1);

            switch(final){
                case "1":
                resultado = "Switch - Segunda-Feira";
                break;

                case "2":
                resultado = "Switch - Segunda-Feira";
                break;

                case "3":
                resultado = "Switch - Terça-Feira";
                break;

                case "4":
                resultado = "Switch - Terça-Feira";
                break;

                case "5":
                resultado = "Switch - Quarta-Feira";
                break;

                case "6":
                resultado = "Switch - Quarta-Feira";
                break;

                case "7":
                resultado = "Switch - Quinta-Feira";
                break;

                case "8":
                resultado = "Switch - Quinta-Feira";
                break;

                case "9":
                resultado = "Switch - Sexta-Feira";
                break;

                case "0":
                resultado = "Switch - Sexta-Feira";
                break;

                default:
                resultado = "Switch - Placa inválida!";
                break;
            }
            Console.WriteLine(resultado);
        }
    }
}
