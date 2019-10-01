using System;
using exercicio3.Controllers;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularController celular = new CelularController();

            Console.Clear();

            celular.Ligar();

            celular.FazerLigacao();

            celular.EnviarMensagem();

            celular.Desligar();

            celular.FazerLigacao();

            celular.EnviarMensagem();
        }
    }
}
