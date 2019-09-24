using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamamos nossa primeira função
            Console.WriteLine(BomDia());
            //Chamamos a função do tipo VOID(sem retorno)
            ImprimeDataHora();
            //Chamamos nossa função que calcula a média
            double[] numeros = {2, 5, 2, 8, 9, 5};
            Console.WriteLine(CalculaMedia(numeros));
            Console.WriteLine(SomaValores(numeros));

        }

        /// <summary>
        /// Função que escreve bom dia para o usuário
        /// </summary>
        /// <returns>
        /// Retorna Olá! Bom dia!
        /// </returns>

        static string BomDia(){
            return "Olá! Bom dia!";
        }
        
        /// <summary>
        /// Função que mostra uma saudação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao">Um texto qualquer(sobrecarga de método)</param>
        /// <returns>Saudação de acordo com o horário</returns>
        static string BomDia(string saudacao){

            int hora = DateTime.Now.Hour;

            if(hora >= 6 && hora <= 11){
                saudacao = "Bom dia";
            }else if(hora >= 12 && hora <= 18){
                saudacao = "Boa tarde";
            }else{
                saudacao = "Boa noite";
            }

            return saudacao;
        }

        /// <summary>
        /// Retorna um número - Teste de Sobrecarga
        /// </summary>
        /// <param name="numero">Um número inteiro qualquer</param>
        /// <returns>Número passado como parâmetro</returns>
        static int BomDia(int numero){
            return numero;
        }

        /// <summary>
        /// Função que retorna Data e Hora atuais
        /// </summary>
        static void ImprimeDataHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour);
        }

        /// <summary>
        /// Função que calcula a média de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Média dos valores</returns>
        static double CalculaMedia( double[] valores){

            double resultado = 0;

            for(int i = 0; i < valores.Length; i++){
                resultado += valores[i];
            }
            resultado = resultado / valores.Length;

            return resultado;
        }
        
        /// <summary>
        /// Função que soma os valores do vetor
        /// </summary>
        /// <param name="valor">Vetor com valores</param>
        /// <returns>Soma dos valores</returns>
        static double SomaValores(double[] valor){
            
            double soma = 0;

            for(int i = 0; i < valor.Length; i++){
                soma += valor[i];
            }
            return soma;
        }
    }
}
