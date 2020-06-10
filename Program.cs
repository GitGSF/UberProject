using System;

namespace UberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro Passageiro = new Passageiro() ;
            Motorista motorista = new Motorista();
            
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
            
        }
    }
}
