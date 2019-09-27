using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar uma função do tipo void que escreve no console o atual dia da semana usando Datetime
            ImprimeSemana();
        }
        static void ImprimeSemana(){
            
            Console.WriteLine(DateTime.Now.DayOfWeek);
        }
    }
}
