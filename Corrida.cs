namespace UberProject
{
    public class Corrida
    {
        public int localInicio { get; set; }
        public int localChegada { get; set; }
        public string statusCorrida { get; set; }
        public string motorista { get; set; }
        public string passageiro { get; set; }

        public int valorKm { get; set; }
        public int kmcorrida { get; set; }
        public int valorTotal { get; set; }

        public string Cancelar(){
            return "Corrida Cancelada, sem taxas cobradas! ";
        }
        
        public void ValorCorrida(){
            motorista = "Adalberto";
            passageiro = "Usuario";
            localInicio = 35;
            localChegada =78;
            kmcorrida = localChegada - localInicio;
        }
    }
}