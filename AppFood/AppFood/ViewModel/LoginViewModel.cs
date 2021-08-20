using AppFood.Models;
using AppFooD.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace AppFood.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }


        public LoginViewModel()
        {

        }

        public AccountUser VerificarLogin(List<AccountUser> ListContas)
        {
            if (Email != "" && Senha != "")
            {
                var conta = ListContas.FirstOrDefault(c => c.Email == this.Email && c.Senha == this.Senha);
                if (conta != null)
                {
                    
                    conta.Logado = true;
                    LimparCampos();
                    return conta;
                }
            }

            return null;
        }
        public void LimparCampos()
        {
            Email = "";
            Senha = "";
        }
        public ICommand CadastroCommand { get; set; }
        public ICommand LoginAccountCommand { get; set; }
    }
}
