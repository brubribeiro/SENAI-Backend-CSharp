using System;
using exemplo2.Models;

namespace exemplo2.Controllers
{
    public class CarroController
    {
        CarroModel carro = new CarroModel();
        MotorModel motor = new MotorModel();

        public void Ligar(){
            carro.Ligado = true;
            System.Console.WriteLine("Ligando carro!");
        }
        public void Desligar(){
            carro.Ligado = false;
            System.Console.WriteLine("Desligando carro...");
        }
        public void Acelerar(){
            if(carro.Ligado == true){
                System.Console.WriteLine("Carro acelerando!!");
            }else{
                System.Console.WriteLine("O carro não está ligado! Impossível acelerar!");
            }
        }
        public void Frear(){
            if(carro.Ligado == true){
                System.Console.WriteLine("Carro freando...");
            }else{
                System.Console.WriteLine("O carro não está ligado! Impossível frear!");
            }
        }
        public void CadastrarMotor(){
            System.Console.WriteLine("Insira quantos cavalos tem o motor: ");
            motor.Cavalos = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira quantos cilindros tem o motor: ");
            motor.Cilindros = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o modelo do pistão do motor: ");
            motor.Pistao = Console.ReadLine();

            //Anterior (errado)
            //carro.Motor.Cavalor = int.Parse(Console.ReadLine());
        }
    }
}