using AppFood.Models;
using AppFooD.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AppFood.ViewModel
{
    public class RegisterViewModel : BaseViewModel
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Numero { get; set; }
        public string Senha { get; set; }
        public ICommand CriarContaCommand { get; set; }
        public AccountUser Conta { get; set; }
        public bool CadastroAcoount(List<AccountUser> contas)
        {

            if (Nome != "" && Email != "" && Senha != "" && Numero != "" && SobreNome != "")
            {
                Conta = new AccountUser
                {
                    AccountID = +1,
                    Nome = this.Nome,
                    Sobrenome = this.SobreNome,
                    Senha = this.Senha,
                    Email = this.Email,
                    Numero = this.Numero,
                    Pedidos = new List<AppFooD.Models.Pedido>()
                };
                if(Conta != null)
                {
                    contas.Add(Conta);
                    LimparCampos();
                    return true;
                }
            }
            return false;
        }

        public void LimparCampos()
        {
            Nome = "";
            SobreNome = "";
            Numero = "";
            Senha = "";
            Email = "";
        }
    }
}
