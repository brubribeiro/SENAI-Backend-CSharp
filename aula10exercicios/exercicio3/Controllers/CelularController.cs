using exercicio3.Models;

namespace exercicio3.Controllers
{
    public class CelularController
    {
        CelularModel celular = new CelularModel();

        public void Ligar(){
            celular.Ligado = true;
            System.Console.WriteLine("Ligando celular...");
        }
        public void Desligar(){
            celular.Ligado = false;
            System.Console.WriteLine("Desligando celular...");
        }
        public void FazerLigacao(){
            if(celular.Ligado == true){
                System.Console.WriteLine("Fazendo uma ligação");
            }else{
                System.Console.WriteLine("O celular está desligado! Impossível fazer uma ligação");
            }
        }
        public void EnviarMensagem(){
            if(celular.Ligado == true){
                System.Console.WriteLine("Enviando uma mensagem");
            }else{
                System.Console.WriteLine("O celular está desligado! Impossível enviar uma mensagem");
            }
        }
    }
}