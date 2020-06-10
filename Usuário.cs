namespace UberProject
{
    public class Usuário
    {
     public string Nome { get; set; }

     private string login = "Usuario123@gmail.com";
     private string senha = "Usuario123";
     public string Foto { get; set; }
     public string LocalizacaoAtual { get; set; }
     public string TokenLogin { get; set; }
     
     public bool Login(string login, string senha){
        if(this.login == login && this.senha == senha){

            TokenLogin = "Usuario123";
                return true;
            }

            return false;
        }

        public void Logout(){
            TokenLogin = "";
        }
    }
}