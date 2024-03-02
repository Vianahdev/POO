using System;
using System.Security.Cryptography.X509Certificates;

namespace CursoPOODotNet{
    class Program{
        static void Main(string[] args){
            var pagCartao = new PaymentsCard();
            pagCartao.pessoa_Name = "Matheus Santos";
            pagCartao.Vencimento = DateTime.Now;
            pagCartao.pessoa_CPF = "804.462.250-02";
            pagCartao.numCartao(435634636);

            
            var pagBoleto = new PaymentsBoleto();
            pagBoleto.pessoa_Name = "Gabriel Diniz";
            pagCartao.Vencimento = DateTime.Now;
            pagBoleto.pessoa_CPF = "857.838.770-85";
            pagBoleto.codigoBoleto(0989434672);
        }
    }

    class Payments{
        //Propriedades
        public DateTime Vencimento;
        public string pessoa_Name;
        public string pessoa_CPF;

        //Métodos
        public void Pagar(){ 
        }
    }

    class PaymentsCard : Payments{
        
        public void numCartao(int numCartao){
            validaNumCartao(numCartao);
        }

        private void validaNumCartao(int numCartao){
            return;
        }
    }

    class PaymentsBoleto : Payments{
        public void codigoBoleto(int codBoleto){

        }
    }
}