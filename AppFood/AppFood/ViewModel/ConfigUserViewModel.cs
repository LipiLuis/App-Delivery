using AppFood.Models;
using AppFooD.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AppFood.ViewModel
{
   public class ConfigUserViewModel : BaseViewModel
    {



        private AccountUser _Account;
        public AccountUser Account
        {
            get { return _Account; }
            set { SetProperty(ref _Account, value); }
        }

        public ICommand  ChamarTelaCadastro { get; set; }
        public ICommand ChamarTelaLogin { get; set; }
        public ICommand SairContaCommand { get; set; }
        public ConfigUserViewModel()
        {
            Account = new AccountUser();
        }
    }
}
