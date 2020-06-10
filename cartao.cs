namespace UberProject
{
    public class cartao
    {
       public string numero { get; set; }
       public string titular { get; set; }
       public string bandeira { get; set; }
       public string cvv { get; set; }

       public string Cadastrar(){
           return "Cartão cadastrado com sucesso , você já pode realizar suas corridas! ";
       }
       public void Excluir(){
           System.Console.WriteLine("Cartão Excluído!");
       }
    }
}