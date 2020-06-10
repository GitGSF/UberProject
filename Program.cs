using System;

namespace UberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro Passageiro = new Passageiro() ;
            Motorista motorista = new Motorista();
            Corrida corrida = new Corrida();
            
            System.Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            Passageiro.Login(login,senha);

               if ( Passageiro.TokenLogin != "" && Passageiro.TokenLogin != null){
                
                System.Console.WriteLine(Passageiro.TokenLogin);
                System.Console.WriteLine("Login Realizado, seja bem vindo");


            }else{
                System.Console.WriteLine("email ou senha ínvalidos! Tente novamente");
            }
            

            //Passageiro info
             Console.WriteLine(Passageiro.ProcurandoMotorista());
            Console.WriteLine();

            Console.WriteLine("Destino definido.");
            Console.WriteLine("Corrida iniciada.");

            Console.WriteLine("A quilometragem da corrida é de "+corrida.kmcorrida+"km.");
            System.Console.WriteLine(corrida);
            Console.WriteLine(Passageiro.Pagar("Finalizado"));

            Console.WriteLine("Corrida finalizada.");

            //Motorista info
   
            Console.WriteLine("Aceitar passagerio? \aSim. \aNão.");
            motorista.aceitar = Console.ReadLine();
            Console.WriteLine(motorista.aceitarPassageiro(""));
            Console.WriteLine();

            System.Console.WriteLine(motorista.CarroPlaca());

            
            Console.WriteLine(motorista.receberPagamento()); 
            
        }
    }
}
