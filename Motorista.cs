using System;

namespace UberProject
{
    public class Motorista
    {
        public string carro {get; set; }
        public string placa {get; set; }
        public string aceitar { get; set; }

        public string aceitarPassageiro( string nome ){
            if(aceitar == "Sim"){

                return "Passageiro aceito: "+nome;

            }else if(aceitar == "Não"){

                return "Passageiro recusado: "+nome;

            }else{

            return "Valor Inválido";
              }
        }
       
        public bool receberPagamento(){
            System.Console.WriteLine("Pagamento recebido.");
            return true;}

           public string CarroPlaca(){
            return "Carro: {carro}";

    }
    }

}