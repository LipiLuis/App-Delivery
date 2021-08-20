using AppFooD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace AppFooD.ViewModel
{
    public class ListaProdutoViewModel : BaseViewModel
    {

        private int _QtdItensPedido;
        public int QtdItensPedido
        {
            get { return _QtdItensPedido; }
            set { SetProperty(ref _QtdItensPedido, value); }
        }
        public ListaProdutoViewModel()
        {
        }

        public List<Produto> ListaProdutos { get; set; }
        public ICommand ExibirProdutoCommand { get; set; }
        public ICommand ExibirCarrinhoProdutosCommand { get; set; }
    }
}
