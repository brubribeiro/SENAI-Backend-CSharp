using exemplo2.Models;

namespace exemplo2.Controllers
{
    public class CarroEletricoController : CarroController
    {
        //Declarando objeto CarroEletricoModel
        CarroEletricoModel carroEletrico = new CarroEletricoModel();

        //Declarando objeto MotorModel
        MotorModel motor = new MotorModel();

        public void CarregarBateria(float carga){
            if(carroEletrico.Bateria < 100){
                carroEletrico.Bateria += carga;
                // Mesma coisa que ....
                //carroEletrico.Bateria = carroEletrico.Bateria + carga;
            }else{
                System.Console.WriteLine("A bateria do carro já está completa! Pode viajar!!");
            }
        }
        public float StatusBateria(){
            return carroEletrico.Bateria;
        }




    }
}