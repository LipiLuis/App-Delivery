using AppFooD.Models;
using AppFooD.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace AppFood.ViewModel
{
   public class EnderecoViewModel : BaseViewModel
    {

        private ObservableCollection<Endereco> _ListEndereco;
        public ObservableCollection<Endereco> ListEndereco
        {
            get { return _ListEndereco; }
            set { SetProperty(ref _ListEndereco, value); }
        }
        public bool IsVisibleAddress = false;
        private Endereco _EnderecoSelecionado;
        public Endereco EnderecoSelecionado
        {
            get { return _EnderecoSelecionado; }
            set { SetProperty(ref _EnderecoSelecionado, value); }
        }
        public ICommand CadastroPedidoCommand { get; set; }
        public ICommand CadastroNovoEnderecoCommand { get; set; }
        public ICommand BuscarEstabelecimentoCommand { get; set; }

        public EnderecoViewModel()
        {
            
        }
    }
}
