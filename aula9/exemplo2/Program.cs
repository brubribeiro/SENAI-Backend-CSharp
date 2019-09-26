﻿using System;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {   
            int numero;

            try
            {
                // Escrevemos um bloco de código
                Console.WriteLine("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                // Mostramos a exceção da regra
                // Erro gerado na aplicação
                Console.WriteLine("Ops :( Deu ruim!. Erro: " + ex);
            }
        }
    }
}
