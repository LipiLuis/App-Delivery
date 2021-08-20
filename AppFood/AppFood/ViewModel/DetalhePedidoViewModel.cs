using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using AppFooD.Helps;
using AppFooD.Models;
using AppFooD.Services;
using AppFooD.ViewModel;

namespace AppFood.ViewModel
{
   public class DetalhePedidoViewModel : BaseViewModel
    {
        private Pedido _pedido;
        public Pedido pedido
        {
            get { return _pedido; }
            set { SetProperty(ref _pedido, value); }
        }

        public ICommand RefazerPedidoCommand { get; set; }
        private List<Produto> _Produtos;
        public List<Produto> Produtos
        {
            get { return _Produtos; }
            set { SetProperty(ref _Produtos, value); }
        }

        private Estabelecimento _estabelecimento;
        public Estabelecimento estabelecimento
        {
            get { return _estabelecimento; }
            set { SetProperty(ref _estabelecimento, value); }
        }
        public DetalhePedidoViewModel()
        {
            
        }

        public void PegaEstabelecimentos()
        {
            estabelecimento = new EstabelecimentoServices().GetEstabelecimentos()
    .FirstOrDefault(e => e.EstabelecimentoID == pedido.EstabelecimentoID);

        }
    }
}
