using System;
using exemplo2.Controllers;
using exemplo2.Models;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroController carro = new CarroController();
            CarroEletricoController carroEletrico = new CarroEletricoController();
            MotorModel motor = new MotorModel();

            Console.Clear(); //Limpa a tela do terminal

            carroEletrico.Ligar();
            carroEletrico.CarregarBateria(100);
            carroEletrico.CarregarBateria(15);

            System.Console.WriteLine("Carga do carro: " + carroEletrico.StatusBateria());

            
        }
    }
}
